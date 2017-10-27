' <snippetentityfilter>



 ' An array SchemaName values for non-intersect, user-owned entities that should not be returned.
                   Dim excludedEntities() As String =
                       {
                           "WorkflowLog",
                           "Template",
                           "CustomerOpportunityRole",
                           "Import",
                           "UserQueryVisualization",
                           "UserEntityInstanceData",
                           "ImportLog",
                           "RecurrenceRule",
                           "QuoteClose",
                           "UserForm",
                           "SharePointDocumentLocation",
                           "Queue",
                           "DuplicateRule",
                           "OpportunityClose",
                           "Workflow",
                           "RecurringAppointmentMaster",
                           "CustomerRelationship",
                           "Annotation",
                           "SharePointSite",
                           "ImportData",
                           "ImportFile",
                           "OrderClose",
                           "Contract",
                           "BulkOperation",
                           "CampaignResponse",
                           "Connection",
                           "Report",
                           "CampaignActivity",
                           "UserEntityUISettings",
                           "IncidentResolution",
                           "GoalRollupQuery",
                           "MailMergeTemplate",
                           "Campaign",
                           "PostFollow",
                           "ImportMap",
                           "Goal",
                           "AsyncOperation",
                           "ProcessSession",
                           "UserQuery",
                           "ActivityPointer",
                           "List",
                           "ServiceAppointment"
                       }

 'A filter expression to limit entities returned to non-intersect, user-owned entities not found in the list of excluded entities.
 Dim EntityFilter As New MetadataFilterExpression(LogicalOperator.And)
 EntityFilter.Conditions.Add(New MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, False))
 EntityFilter.Conditions.Add(New MetadataConditionExpression("OwnershipType", MetadataConditionOperator.Equals, OwnershipTypes.UserOwned))
 EntityFilter.Conditions.Add(New MetadataConditionExpression("SchemaName", MetadataConditionOperator.NotIn, excludedEntities))
 Dim isVisibileInMobileTrue As New MetadataConditionExpression("IsVisibleInMobile", MetadataConditionOperator.Equals, True)
 EntityFilter.Conditions.Add(isVisibileInMobileTrue)

' </snippetentityfilter>