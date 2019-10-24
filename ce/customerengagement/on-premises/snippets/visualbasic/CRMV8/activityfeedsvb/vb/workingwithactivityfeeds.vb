' <snippetworkingwithactivityfeeds>


Imports System.ServiceModel
Imports System.Threading
Imports Microsoft.Crm.Sdk.Messages
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to work with the new Activity Feeds entities, including Post,
    ''' PostFollow, and PostComment.</summary>
    ''' <remarks>
    ''' At run-time, you will be given the option to delete all the
    ''' database records created by this program.</remarks>
    Public Class WorkingWithActivityFeeds
#Region "Local Sample Types"
        Private Class InvalidSampleExecutionException
            Inherits Exception
            Public Sub New(ByVal message As String)
                MyBase.New(message)
            End Sub
        End Class
#End Region ' Local Sample Types

#Region "Class Level Members"
        Private _serviceProxy As OrganizationServiceProxy
        Private _serviceContext As ServiceContext
        Private _originalLeadConfig As msdyn_PostConfig
        Private _originalSystemUserConfig As msdyn_PostConfig
        Private _systemuserConfig As msdyn_PostConfig
        Private _leadConfig As msdyn_PostConfig
        Private _postRuleConfigs As New List(Of msdyn_PostRuleConfig)()
        Private _lead1 As Lead
        Private _lead2 As Lead
        Private _lead3 As Lead
        Private _follow1 As PostFollow
        Private _follow2 As PostFollow
        Private _follow3 As PostFollow
        Private _generatedEntities As New List(Of EntityReference)()
        Private _post1 As Post
        Private _post2 As Post
        Private _post3 As Post
        Private _post4 As Post
        Private _leadPost1 As Post
#End Region ' Class Level Members

#Region "How To Sample Code"

        ''' <summary>
        ''' This method first connects to the Organization service. Afterwards, activity
        ''' feeds are enabled, posts and comments are made to entity records and user
        ''' walls and auto post rules are demonstrated.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptForDelete As Boolean)
            _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
            Using _serviceProxy
                ' This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes()
                _serviceContext = New ServiceContext(_serviceProxy)

                Try
                    ConfigureActivityFeeds()
                    PostToRecordWalls()
                    PostToPersonalWalls()
                    ShowRecordWalls()
                    DeleteRequiredRecords(promptForDelete)
                Catch e As InvalidSampleExecutionException
                    Console.WriteLine(e.Message)
                    DeleteRequiredRecords(promptForDelete)
                End Try
            End Using
        End Sub

        Private Sub ConfigureActivityFeeds()
            Console.WriteLine("== Configuring Activity Feeds ==")

            ' Get the original systemuser config in order to keep a copy for reverting
            ' after the sample has completed.
            _originalSystemUserConfig = ( _
                From c In _serviceContext.msdyn_PostConfigSet _
                Where c.msdyn_EntityName Is SystemUser.EntityLogicalName _
                Select New msdyn_PostConfig With
                       {
                           .msdyn_PostConfigId = c.msdyn_PostConfigId,
                           .msdyn_ConfigureWall = c.msdyn_ConfigureWall,
            .msdyn_EntityName = c.msdyn_EntityName
                       }).FirstOrDefault()

            ' Retrieve or Create an instance of msdyn_PostConfig to enable activity
            ' feeds for leads (or make sure they are already enabled).
            ' If a new msdyn_PostConfig record gets created, activity feeds for
            ' systemusers will be enabled automatically.
            _leadConfig = ( _
                From c In _serviceContext.msdyn_PostConfigSet _
                Where c.msdyn_EntityName Is Lead.EntityLogicalName _
                Select New msdyn_PostConfig With
                       {
                           .msdyn_PostConfigId = c.msdyn_PostConfigId,
                           .msdyn_EntityName = c.msdyn_EntityName,
                           .msdyn_ConfigureWall = c.msdyn_ConfigureWall
                       }).FirstOrDefault()

            If _leadConfig Is Nothing Then
                ' Create the configuration record for leads.
                _leadConfig = New msdyn_PostConfig With
                              {
                                  .msdyn_EntityName = Lead.EntityLogicalName,
                                  .msdyn_ConfigureWall = True
                              }

                _serviceContext.AddObject(_leadConfig)
                _serviceContext.SaveChanges()
                Console.WriteLine("  The lead activity feed wall configuration was created.")
            Else
                ' Store the original Lead Config so that we can revert changes later.
                _originalLeadConfig = CloneRevelantConfiguration(_leadConfig)

                If (Not _leadConfig.msdyn_ConfigureWall.HasValue) _
                    OrElse (Not _leadConfig.msdyn_ConfigureWall.Value) Then
                    _leadConfig.msdyn_ConfigureWall = True

                    _serviceContext.UpdateObject(_leadConfig)
                    _serviceContext.SaveChanges()
                    Console.WriteLine("  The lead activity feed wall was enabled.")
                End If
            End If

            ' Get the original systemuser config in order to keep a copy for reverting
            ' after the sample has completed.
            _systemuserConfig = ( _
                From c In _serviceContext.msdyn_PostConfigSet _
                Where c.msdyn_EntityName Is SystemUser.EntityLogicalName _
                Select New msdyn_PostConfig With
                       {
                           .msdyn_PostConfigId = c.msdyn_PostConfigId,
                           .msdyn_ConfigureWall = c.msdyn_ConfigureWall,
                           .msdyn_EntityName = c.msdyn_EntityName
                       }).FirstOrDefault()

            ' Ensure that the wall for systemuser is enabled if there is already a
            ' systemuser configuration defined.
            If _systemuserConfig IsNot Nothing AndAlso
                ((Not _systemuserConfig.msdyn_ConfigureWall.HasValue) OrElse
                 (Not _systemuserConfig.msdyn_ConfigureWall.Value)) Then
                _systemuserConfig.msdyn_ConfigureWall = True

                _serviceContext.UpdateObject(_systemuserConfig)
                _serviceContext.SaveChanges()
                Console.WriteLine("  The systemuser activity feed wall was enabled.")
            End If

            ' Publish the lead and systemuser entities so that they will have record
            ' walls on their forms.
            PublishSystemUserAndLead()

            ' Activate the auto post rule configurations. New Lead qualified should be
            ' activated automatically when the rule is generated by CRM.
            Dim leadRules = ( _
                From r In _serviceContext.msdyn_PostRuleConfigSet _
                Where r.msdyn_RuleId Is "LeadQualify.Yes.Rule" OrElse
                r.msdyn_RuleId Is "LeadCreate.Rule" _
                Select r).ToList()
            If leadRules.Count() <> 2 Then
                Throw New InvalidSampleExecutionException( _
                    "  One or both of the lead config rules do not exist." _
                    &amp; "This can be fixed by deleting the lead post config.")
            End If
            For Each configRule In leadRules
                _postRuleConfigs.Add(configRule)
                ActivateRuleConfig(configRule)
            Next configRule
        End Sub

        Private Sub PostToRecordWalls()
            Console.WriteLine(vbCrLf &amp; "== Working with Record Walls ==")
            ' Create the leads.
            CreateRequiredRecords()

            ' Follow each of the leads.
            _follow1 = New PostFollow With
                       {
                           .RegardingObjectId = _lead1.ToEntityReference()
                       }
            _serviceContext.AddObject(_follow1)

            _follow2 = New PostFollow With
                       {
                           .RegardingObjectId = _lead2.ToEntityReference()
                       }
            _serviceContext.AddObject(_follow2)

            _follow3 = New PostFollow With
                       {
                           .RegardingObjectId = _lead3.ToEntityReference()
                       }
            _serviceContext.AddObject(_follow3)

            _serviceContext.SaveChanges()
            Console.WriteLine("  The 3 leads are now followed.")

            ' Create posts, mentions, and comments related to the leads.
            ' Create a post related to lead 1 with a mention and a comment.
            _leadPost1 = New Post With
                         {
                             .RegardingObjectId = _lead1.ToEntityReference(),
                             .Source = New OptionSetValue(CInt(Fix(PostSource.AutoPost))),
                             .Text = String.Format("This lead is similar to @[{0},{1},""{2}""]",
                                                   Lead.EntityTypeCode,
                                                   _lead2.Id,
                                                   _lead2.FullName)
                         }
            ' Include a mention in the post text.

            _serviceContext.AddObject(_leadPost1)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Post 1 has been created.")

            ' It isn't necessary to keep track of the comment because the comment will
            ' be deleted when its parent post is deleted.
            Dim comment1 = New PostComment With
                           {
                               .PostId = _leadPost1.ToEntityReference(),
                               .Text = "Sample comment 1"
                           }
            _serviceContext.AddObject(comment1)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Comment 1 has been created.")

            ' Create a post related to lead 2 with three comments.
            Dim post2 = New Post With
                        {
                            .RegardingObjectId = _lead2.ToEntityReference(),
                            .Source = New OptionSetValue(CInt(Fix(PostSource.ManualPost))),
                            .Text = "This lead was created for a sample."
                        }

            _serviceContext.AddObject(post2)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Post 2 has been created.")

            Dim comment2 = New PostComment With
                           {
                               .PostId = post2.ToEntityReference(),
                               .Text = "Sample comment 2"
                           }

            Dim comment3 = New PostComment With
                           {
                               .PostId = post2.ToEntityReference(),
                               .Text = "Sample comment 3"
                           }

            Dim comment4 = New PostComment With
                           {
                               .PostId = post2.ToEntityReference(),
                               .Text = "Sample comment 4"
                           }

            _serviceContext.AddObject(comment2)
            _serviceContext.AddObject(comment3)
            _serviceContext.AddObject(comment4)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Comments 2, 3, and 4 have been created.")

            ' Qualify some leads.  Since there is an active post rule config for
            ' qualification of a lead, this should generate an auto post to the record
            ' wall of each lead that is qualified.

            ' Qualify lead 2.
            Dim qualifyLead2Request = New QualifyLeadRequest With
                                      {
                                          .CreateAccount = True,
                                          .LeadId = _lead2.ToEntityReference(),
                                          .Status =
                                          New OptionSetValue(
                                              CInt(Fix(lead_statuscode.Qualified)))
                                      }

            Dim qualifyLead2Response = CType(_serviceProxy.Execute(qualifyLead2Request), 
                QualifyLeadResponse)

            ' Store the generated Account to delete it later.
            For Each entityRef In qualifyLead2Response.CreatedEntities
                _generatedEntities.Add(entityRef)
            Next entityRef

            Console.WriteLine("  Lead 2 was qualified.")

            ' Qualify lead 3.
            Dim qualifyLead3Request = New QualifyLeadRequest With
                                      {
                                          .CreateAccount = True,
                                          .LeadId = _lead3.ToEntityReference(),
                                          .Status = New OptionSetValue(
                                              CInt(Fix(lead_statuscode.Qualified)))
                                      }

            Dim qualifyLead3Response = CType(_serviceProxy.Execute(qualifyLead3Request), 
                QualifyLeadResponse)

            For Each entityRef In qualifyLead3Response.CreatedEntities
                _generatedEntities.Add(entityRef)
            Next entityRef

            Console.WriteLine("  Lead 3 was qualified.")
        End Sub

        Private Sub PostToPersonalWalls()
            Console.WriteLine(vbCrLf &amp; "== Working with Personal Walls ==")
            ' Create manual (user) posts on a user's Personal wall.
            Dim whoAmIRequest = New WhoAmIRequest()
            Dim whoAmIResponse = CType(_serviceProxy.Execute(whoAmIRequest), 
                WhoAmIResponse)
            Dim currentUserRef = New EntityReference(SystemUser.EntityLogicalName,
                                                     whoAmIResponse.UserId)

            ' Create a post that mentions lead 1.
            ' The Regarding object should be set to the user whose wall the post should
            ' be posted to (we'll just use the current user).
            _post1 = New Post With
                     {
                         .RegardingObjectId = currentUserRef,
                         .Source = New OptionSetValue(CInt(Fix(PostSource.ManualPost))),
                         .Text = String.Format("I'd rather not pursue @[{0},{1},""{2}""]",
                                               Lead.EntityTypeCode,
                                               _lead1.Id,
                                               _lead1.FullName)
                     }

            _serviceContext.AddObject(_post1)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Personal wall post 1 was created.")

            ' Create a related comment.
            Dim comment1 = New PostComment With
                           {
                               .PostId = _post1.ToEntityReference(),
                               .Text = "Personal wall comment 1."
                           }

            _serviceContext.AddObject(comment1)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Personal wall comment 1 was created.")

            _post2 = New Post With
                     {
                         .RegardingObjectId = currentUserRef,
                         .Source = New OptionSetValue(CInt(Fix(PostSource.AutoPost))),
                         .Text = "Personal wall post 2."
                     }

            _serviceContext.AddObject(_post2)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Personal wall post 2 was created.")

            ' Create a few related comments.
            Dim comment2 = New PostComment With
                           {
                               .PostId = _post2.ToEntityReference(),
                               .Text = "Personal wall comment 2."
                           }

            Dim comment3 = New PostComment With
                           {
                               .PostId = _post2.ToEntityReference(),
                               .Text = "Personal wall comment 3."
                           }

            Dim comment4 = New PostComment With
                           {
                               .PostId = _post2.ToEntityReference(),
                               .Text = "Personal wall comment 4."
                           }

            Dim comment5 = New PostComment With
                           {
                               .PostId = _post2.ToEntityReference(),
                               .Text = "Personal wall comment 5."
                           }

            _serviceContext.AddObject(comment2)
            _serviceContext.AddObject(comment3)
            _serviceContext.AddObject(comment4)
            _serviceContext.AddObject(comment5)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Personal wall comments 2, 3, 4, and 5 were created.")

            ' Create a couple more posts just to show how paging works.
            _post3 = New Post With
                     {
                         .RegardingObjectId = currentUserRef,
                         .Source = New OptionSetValue(
                             CInt(Fix(PostSource.ManualPost))),
                         .Text = "Personal wall post 3."
                     }

            _post4 = New Post With
                     {
                         .RegardingObjectId = currentUserRef,
                         .Source = New OptionSetValue(
                             CInt(Fix(PostSource.AutoPost))),
                         .Text = "Personal wall post 4."
                     }

            _serviceContext.AddObject(_post3)
            _serviceContext.AddObject(_post4)
            _serviceContext.SaveChanges()
            Console.WriteLine("  Personal wall posts 3 and 4 were created.")

            ' Retrieve this user's personal wall.
            ' Retrieve the first page of posts.
            DisplayPersonalWallPage(1)

            ' Retrieve the second page of posts.
            DisplayPersonalWallPage(2)

            ' Sleep for a second so that the time of the newly created comment will
            ' clearly be later than the previously created posts/comments (otherwise
            ' Post 3 will not be escalated to the top of the wall).
            Thread.Sleep(1000)

            ' Create a new comment on the last post, which will bring the post to the
            ' top.
            Dim newPostComment =
                New PostComment With
                {
                    .PostId = _post3.ToEntityReference(),
                    .Text = "New comment to show that new comments affect post ordering."
                }

            _serviceContext.AddObject(newPostComment)
            _serviceContext.SaveChanges()
            Console.WriteLine(
                vbCrLf _
                &amp; "  A new comment was created to show effects on post ordering.")

            ' Display the first page of the personal wall to showcase the change in
            ' ordering.  Post 3 should be at the top.
            DisplayPersonalWallPage(1)

            ' Show paging of comments.
            ' Retrieve comments 2 at a time, starting with page 1.
            Dim commentsQuery = New QueryExpression(PostComment.EntityLogicalName) With
                                {
                                    .ColumnSet = New ColumnSet(True),
                                    .Criteria = New FilterExpression(LogicalOperator.And),
                                    .PageInfo = New PagingInfo With
                                                {
                                                    .Count = 2,
                                                    .PageNumber = 1,
                                                    .ReturnTotalRecordCount = True
                                                }
                                }

            commentsQuery.Criteria.AddCondition("postid",
                                                ConditionOperator.Equal,
                                                _post2.Id)

            ' Continue querying for comments until there are no further comments to
            ' be retrieved.
            Dim commentsResult As EntityCollection
            Do
                commentsResult = _serviceProxy.RetrieveMultiple(commentsQuery)

                ' Display the comments that we retrieved.
                Console.WriteLine(vbCrLf &amp; "  Comments for lead 2 page {0}",
                                  commentsQuery.PageInfo.PageNumber)
                For Each comment As PostComment In commentsResult.Entities
                    DisplayComment(comment)
                Next comment

                commentsQuery.PageInfo.PageNumber += 1
            Loop While commentsResult.MoreRecords
        End Sub

        Private Sub ShowRecordWalls()
            Console.WriteLine(vbCrLf &amp; "== Showing Record Walls ==")

            ' Create a new post on one of the leads.
            Dim newLeadPost = New Post With
                              {
                                  .Source = New OptionSetValue(
                                      CInt(Fix(PostSource.AutoPost))),
                                  .Text = "New lead post.",
                                  .RegardingObjectId = _lead2.ToEntityReference()
                              }

            _serviceContext.AddObject(newLeadPost)
            _serviceContext.SaveChanges()
            Console.WriteLine("  The new lead 2 post has been created.")

            DisplayRecordWall(_lead1)
            DisplayRecordWall(_lead2)
            DisplayRecordWall(_lead3)
        End Sub

        Private Sub DisplayRecordWall(ByVal lead As Lead)
            ' Display the first page of the record wall.
            Dim retrieveRecordWallReq = New RetrieveRecordWallRequest With
                                        {
                                            .Entity = lead.ToEntityReference(),
                                            .CommentsPerPost = 2,
                                            .PageSize = 10,
                                            .PageNumber = 1
                                        }

            Dim retrieveRecordWallRes = CType(_serviceProxy.Execute(retrieveRecordWallReq), 
                RetrieveRecordWallResponse)

            Console.WriteLine(vbCrLf &amp; "  Posts for lead {0}:", lead.FullName)
            For Each post As Post In retrieveRecordWallRes.EntityCollection.Entities
                DisplayPost(post)
            Next post
        End Sub


        Private Sub DisplayPersonalWallPage(ByVal pageNumber As Integer)
            ' Retrieve the page of posts.  We'll only retrieve 5 at a time so that
            ' we will have more than one page.
            Dim pageSize = 5

            Dim personalWallPageReq = New RetrievePersonalWallRequest With
                                      {
                                          .CommentsPerPost = 2,
                                          .PageNumber = pageNumber,
                                          .PageSize = pageSize
                                      }
            Dim personalWallPageRes = CType(_serviceProxy.Execute(personalWallPageReq), 
                RetrievePersonalWallResponse)

            Console.WriteLine(vbCrLf &amp; "  Personal Wall Page {0} Posts:", pageNumber)
            For Each post As Post In personalWallPageRes.EntityCollection.Entities
                DisplayPost(post)
            Next post
        End Sub


        Private Sub DisplayPost(ByVal post As Post)
            Console.WriteLine("    Post, {0}, {1}, {2}: {3}",
                              post.CreatedBy.Name,
                              CType(post.Type.Value, PostType),
                              CType(post.Source.Value, PostSource),
                              Shorten(post.Text))

            If post.Post_Comments IsNot Nothing Then
                For Each comment In post.Post_Comments
                    DisplayComment(comment)
                Next comment
            End If
        End Sub

        Private Sub DisplayComment(ByVal comment As PostComment)
            Console.WriteLine("      Comment, {0}: {1}",
                              comment.CreatedBy.Name,
                              Shorten(comment.Text))
        End Sub

        Private Function Shorten(ByVal x As String) As String
            Return If(x.Length > 33, x.Substring(0, 30) &amp; "...", x)
        End Function

        Private Sub CreateRequiredRecords()
            ' Create leads for relating activity feed records to. Since there is an
            ' active post rule config for creation of a new lead, creating the leads
            ' should add an auto post to the record wall for each of the leads.
            _lead1 = New Lead With
                     {
                         .CompanyName = "A. Datum Corporation",
                         .FirstName = "Henriette",
                         .MiddleName = "Thaulow",
                         .LastName = "Andersen",
                         .Subject = "Activity Feeds Sample 1"
                     }
            _serviceContext.AddObject(_lead1)

            _lead2 = New Lead With
                     {
                         .CompanyName = "Adventure Works",
                         .FirstName = "Mary",
                         .MiddleName = "Kay",
                         .LastName = "Andersen",
                         .Subject = "Activity Feeds Sample 2"
                     }
            _serviceContext.AddObject(_lead2)

            _lead3 = New Lead With
                     {
                         .CompanyName = "Fabrikam, Inc.",
                         .FirstName = "Andrew",
                         .LastName = "Sullivan",
                         .Subject = "Activity Feeds Sample 3"
                     }
            _serviceContext.AddObject(_lead3)

            _serviceContext.SaveChanges()

            Dim columnSet = New ColumnSet(True)
            _lead1 = CType(_serviceProxy.Retrieve(Lead.EntityLogicalName,
                                                  _lead1.Id, columnSet), 
                                              Lead)
            _lead2 = CType(_serviceProxy.Retrieve(Lead.EntityLogicalName,
                                                  _lead2.Id, columnSet), 
                                              Lead)
            _lead3 = CType(_serviceProxy.Retrieve(Lead.EntityLogicalName,
                                                  _lead3.Id, columnSet), 
                                              Lead)

            Console.WriteLine("  The leads have been created.")
        End Sub

        Private Sub ActivateRuleConfig(ByVal qualifyLeadRule As msdyn_PostRuleConfig)
            _serviceProxy.Execute(New SetStateRequest With
                                  {
                                      .EntityMoniker = qualifyLeadRule.ToEntityReference(),
                                      .State = New OptionSetValue(
                                          CInt(Fix(msdyn_PostRuleConfigState.Active))),
                                      .Status = New OptionSetValue(
                                          CInt(Fix(msdyn_postruleconfig_statuscode.Active)))
                                  })
        End Sub

        Private Function CloneRevelantConfiguration(ByVal config As msdyn_PostConfig) As msdyn_PostConfig
            Return New msdyn_PostConfig With
                   {
                       .msdyn_ConfigureWall = config.msdyn_ConfigureWall,
                       .msdyn_EntityName = config.msdyn_EntityName,
                       .msdyn_PostConfigId = config.msdyn_PostConfigId
                   }
        End Function

        Private Sub PublishSystemUserAndLead()
            ' The systemuser and lead entities must be published because otherwise the
            ' record walls on the respective forms will not update.
            _serviceProxy.Execute(New PublishXmlRequest With
                                  {
                                      .ParameterXml = "" _
                                   &amp; "                    <importexportxml>" _
                                   &amp; "                        <entities>" _
                                   &amp; "                            <entity>systemuser</entity>" _
                                   &amp; "                            <entity>lead</entity>" _
                                   &amp; "                        </entities>" _
                                   &amp; "                    </importexportxml>"
                                  })
            Console.WriteLine("  The systemuser and lead entities were published.")
        End Sub

        Private Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted = True
            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse
                    answer.StartsWith("Y") OrElse
                    answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                ' Handle reverting the configurations appropriately - delete them
                ' if they did not exist before.  Otherwise update them to their
                ' original values.  Lead must be reverted first since it must be deleted
                ' first if systemuser is to be deleted.
                RevertPostConfig(_originalLeadConfig, _leadConfig)
                RevertPostConfig(_originalSystemUserConfig, _systemuserConfig)

                ' Revert the form changes.
                PublishSystemUserAndLead()

                ' Delete the leads.
                DeleteFromContext(_lead1)
                DeleteFromContext(_lead2)
                DeleteFromContext(_lead3)
                Dim saveResult = _serviceContext.SaveChanges()
                Console.WriteLine("  The leads have been deleted.")
                Console.WriteLine("  The post follow records were deleted with the leads.")
                Console.WriteLine("  Posts that were related to leads were deleted with the leads.")

                ' Delete posts that aren't regarding entities that were deleted.
                DeleteFromContext(_post1)
                DeleteFromContext(_post2)
                DeleteFromContext(_post3)
                DeleteFromContext(_post4)
                _serviceContext.SaveChanges()
                Console.WriteLine("  Posts that weren't regarding deleted entities were deleted.")

                ' Delete the generated entities.
                For Each entityRef In _generatedEntities
                    _serviceProxy.Delete(entityRef.LogicalName, entityRef.Id)
                Next entityRef
                Console.WriteLine("  All generated entities have been deleted.")
            End If
        End Sub

        Private Sub DeleteFromContext(ByVal entity As Entity)
            If Not _serviceContext.IsAttached(entity) Then
                _serviceContext.Attach(entity)
            End If
            _serviceContext.DeleteObject(entity)
            _serviceContext.SaveChanges()
        End Sub

        Private Sub RevertPostConfig(ByVal originalConfig As msdyn_PostConfig,
                                     ByVal newConfig As msdyn_PostConfig)
            If originalConfig IsNot Nothing Then
                ' Revert the rule configs.
                For Each rule In _postRuleConfigs.Where(
                    Function(x) x.msdyn_PostConfigId.Id = newConfig.msdyn_PostConfigId.Value)
                    ' Set the state to the original value.
                    _serviceProxy.Execute(New SetStateRequest With
                                          {
                                              .EntityMoniker = rule.ToEntityReference(),
                                              .State = New OptionSetValue(
                                                  CInt(Fix(rule.statecode))),
                                              .Status = rule.statuscode
                                          })
                Next rule

                ' Update the config to the values from the original config.
                ' Make sure the context is not tracking the new config and is tracking
                ' the original config.
                If Not _serviceContext.IsAttached(originalConfig) Then
                    If _serviceContext.IsAttached(newConfig) Then
                        _serviceContext.Detach(newConfig)
                    End If
                    _serviceContext.Attach(originalConfig)
                End If
                _serviceContext.UpdateObject(originalConfig)
                _serviceContext.SaveChanges()
                Console.WriteLine("  The {0} activity feed configuration was reverted.",
                                  originalConfig.msdyn_EntityName)
            Else
                _serviceProxy.Delete(newConfig.LogicalName, newConfig.Id)
                Console.WriteLine("  The {0} activity feed configuration was deleted.",
                                  newConfig.msdyn_EntityName)
            End If
        End Sub

#End Region ' How To Sample Code

#Region "Main method"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app = New WorkingWithActivityFeeds()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
                ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
                ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.
            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try
        End Sub
#End Region ' Main method
    End Class
End Namespace

' </snippetworkingwithactivityfeeds>