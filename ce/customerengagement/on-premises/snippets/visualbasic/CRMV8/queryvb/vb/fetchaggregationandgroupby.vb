' <snippetfetchaggregationandgroupby>


Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System.Threading

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages


Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' Demonstrates how to fetch aggregate record data grouped by attributes.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' Optionally delete all the records created at the end of execution.
    ''' </summary>
    Public Class FetchAggregationAndGroupBy
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        ' Define the IDs needed for this sample.    
        Public _accountId As Guid
        Public _setupOpportunitiyIds() As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create an account record.
        ''' Create 3 opportunity records associate to the account record.
        ''' Mark all 3 opportunity records as won.
        ''' Fetch aggregate record data grouped by attributes.
        ''' Optionally delete all the records created at the end of execution.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()
                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' *****************************************************************************************************************
                    '                FetchXML      estimatedvalue_avg    Aggregate 1
                    ' *****************************************************************************************************************
                    ' Fetch the average of estimatedvalue for all opportunities.  This is the equivalent of 
                    ' SELECT AVG(estimatedvalue) AS estimatedvalue_avg ... in SQL.
                    Console.WriteLine("===============================")
                    Dim estimatedvalue_avg As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg' /> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim estimatedvalue_avg_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_avg))

                    For Each c In estimatedvalue_avg_result.Entities
                        Dim aggregate1 As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average estimated value: " &amp; aggregate1)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      opportunity_count   Aggregate 2
                    ' *****************************************************************************************************************
                    ' Fetch the count of all opportunities.  This is the equivalent of
                    ' SELECT COUNT(*) AS opportunity_count ... in SQL.
                    Dim opportunity_count As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='name' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim opportunity_count_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(opportunity_count))

                    For Each c In opportunity_count_result.Entities
                        Dim aggregate2 As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate2)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      opportunity_colcount   Aggregate 3
                    ' *****************************************************************************************************************
                    ' Fetch the count of all opportunities.  This is the equivalent of 
                    ' SELECT COUNT(name) AS opportunity_count ... in SQL.
                    Dim opportunity_colcount As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='name' alias='opportunity_colcount' aggregate='countcolumn'/> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim opportunity_colcount_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(opportunity_colcount))

                    For Each c In opportunity_colcount_result.Entities
                        Dim aggregate3 As Int32 = CInt(Fix((CType(c("opportunity_colcount"), AliasedValue)).Value))
                        Console.WriteLine("Column count of all opportunities: " &amp; aggregate3)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      opportunity_distcount   Aggregate 4
                    ' *****************************************************************************************************************
                    ' Fetch the count of distinct names for opportunities.  This is the equivalent of 
                    ' SELECT COUNT(DISTINCT name) AS opportunity_count ... in SQL.
                    Dim opportunity_distcount As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='name' alias='opportunity_distcount' aggregate='countcolumn' distinct='true'/> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim opportunity_distcount_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(opportunity_distcount))

                    For Each c In opportunity_distcount_result.Entities
                        Dim aggregate4 As Int32 = CInt(Fix((CType(c("opportunity_distcount"), AliasedValue)).Value))
                        Console.WriteLine("Distinct name count of all opportunities: " &amp; aggregate4)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      estimatedvalue_max   Aggregate 5
                    ' *****************************************************************************************************************
                    ' Fetch the maximum estimatedvalue of all opportunities.  This is the equivalent of 
                    ' SELECT MAX(estimatedvalue) AS estimatedvalue_max ... in SQL.
                    Dim estimatedvalue_max As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_max' aggregate='max' /> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim estimatedvalue_max_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_max))

                    For Each c In estimatedvalue_max_result.Entities
                        Dim aggregate5 As Decimal = (CType((CType(c("estimatedvalue_max"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Max estimated value of all opportunities: " &amp; aggregate5)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      estimatedvalue_min   Aggregate 6
                    ' *****************************************************************************************************************
                    ' Fetch the minimum estimatedvalue of all opportunities.  This is the equivalent of 
                    ' SELECT MIN(estimatedvalue) AS estimatedvalue_min ... in SQL.
                    Dim estimatedvalue_min As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_min' aggregate='min' /> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim estimatedvalue_min_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_min))

                    For Each c In estimatedvalue_min_result.Entities
                        Dim aggregate6 As Decimal = (CType((CType(c("estimatedvalue_min"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Minimum estimated value of all opportunities: " &amp; aggregate6)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      estimatedvalue_sum   Aggregate 7
                    ' *****************************************************************************************************************
                    ' Fetch the sum of estimatedvalue for all opportunities.  This is the equivalent of 
                    ' SELECT SUM(estimatedvalue) AS estimatedvalue_sum ... in SQL.
                    Dim estimatedvalue_sum As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum' /> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim estimatedvalue_sum_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_sum))

                    For Each c In estimatedvalue_sum_result.Entities
                        Dim aggregate7 As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate7)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      estimatedvalue_avg, estimatedvalue_sum   Aggregate 8
                    ' *****************************************************************************************************************
                    ' Fetch multiple aggregate values within a single query.
                    Dim estimatedvalue_avg2 As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim estimatedvalue_avg2_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(estimatedvalue_avg2))

                    For Each c In estimatedvalue_avg2_result.Entities
                        Dim aggregate8a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate8a)
                        Dim aggregate8b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate8b)
                        Dim aggregate8c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate8c)

                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      groupby1   Aggregate 9
                    ' *****************************************************************************************************************
                    ' Fetch a list of users with a count of all the opportunities they own using groupby.
                    Dim groupby1 As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='ownerid' alias='ownerid' groupby='true' /> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim groupby1_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(groupby1))

                    For Each c In groupby1_result.Entities
                        Dim aggregate9a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate9a &amp; vbLf)
                        Dim aggregate9b As String = (CType((CType(c("ownerid"), AliasedValue)).Value, EntityReference)).Name
                        Console.WriteLine("Owner: " &amp; aggregate9b)
                        Dim aggregate9c As String = CStr((CType(c("ownerid_owneridyominame"), AliasedValue)).Value)
                        Console.WriteLine("Owner: " &amp; aggregate9c)
                        Dim aggregate9d As String = CStr((CType(c("ownerid_owneridyominame"), AliasedValue)).Value)
                        Console.WriteLine("Owner: " &amp; aggregate9d)
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      groupby2   Aggregate 10
                    ' *****************************************************************************************************************
                    ' Fetch the number of opportunities each manager's direct reports 
                    ' own using a groupby within a link-entity.
                    Dim groupby2 As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='name' alias='opportunity_count' aggregate='countcolumn' /> " &amp; ControlChars.CrLf &amp; _
                        "                           <link-entity name='systemuser' from='systemuserid' to='ownerid'>" &amp; ControlChars.CrLf &amp; _
                        "                               <attribute name='parentsystemuserid' alias='managerid' groupby='true' />" &amp; ControlChars.CrLf &amp; _
                        "                           </link-entity> " &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim groupby2_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(groupby2))

                    For Each c In groupby2_result.Entities

                          Dim aggregate10a? As Integer = CType((CType(c("opportunity_count"), AliasedValue)).Value, Integer?)
                          Console.WriteLine("Count of all opportunities: " &amp; aggregate10a &amp; vbLf)
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      byyear   Aggregate 11           
                    ' *****************************************************************************************************************
                    ' Fetch aggregate information about the opportunities that have 
                    ' been won by year.
                    Dim byyear As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim byyear_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byyear))

                    For Each c In byyear_result.Entities
                        Dim aggregate11 As Int32 = CInt(Fix((CType(c("year"), AliasedValue)).Value))
                        Console.WriteLine("Year: " &amp; aggregate11)
                        Dim aggregate11a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate11a)
                        Dim aggregate11b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate11b)
                        Dim aggregate11c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate11c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      byquarter   Aggregate 12           
                    ' *****************************************************************************************************************
                   ' Fetch aggregate information about the opportunities that have 
                    ' been won by quarter.(returns 1-4)
                    Dim byquarter As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim byquarter_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byquarter))

                    For Each c In byquarter_result.Entities
                        Dim aggregate12 As Int32 = CInt(Fix((CType(c("quarter"), AliasedValue)).Value))
                        Console.WriteLine("Quarter: " &amp; aggregate12)
                        Dim aggregate12a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate12a)
                        Dim aggregate12b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate12b)
                        Dim aggregate12c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate12c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      bymonth   Aggregate 13           
                    ' *****************************************************************************************************************
                    ' Fetch aggregate information about the opportunities that have 
                    ' been won by month. (returns 1-12)
                    Dim bymonth As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='month' alias='month' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim bymonth_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(bymonth))

                    For Each c In bymonth_result.Entities
                        Dim aggregate13 As Int32 = CInt(Fix((CType(c("month"), AliasedValue)).Value))
                        Console.WriteLine("Month: " &amp; aggregate13)
                        Dim aggregate13a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate13a)
                        Dim aggregate13b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate13b)
                        Dim aggregate13c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate13c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      byweek   Aggregate 14           
                    ' *****************************************************************************************************************
                    ' Fetch aggregate information about the opportunities that have 
                    ' been won by week. (Returns 1-52)
                    Dim byweek As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='week' alias='week' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim byweek_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byweek))

                    For Each c In byweek_result.Entities
                        Dim aggregate14 As Int32 = CInt(Fix((CType(c("week"), AliasedValue)).Value))
                        Console.WriteLine("Week: " &amp; aggregate14)
                        Dim aggregate14a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate14a)
                        Dim aggregate14b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate14b)
                        Dim aggregate14c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate14c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      byday   Aggregate 15           
                    ' *****************************************************************************************************************
                    ' Fetch aggregate information about the opportunities that have 
                    ' been won by day. (Returns 1-31)
                    Dim byday As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='day' alias='day' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim byday_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byday))

                    For Each c In byday_result.Entities
                        Dim aggregate15 As Int32 = CInt(Fix((CType(c("day"), AliasedValue)).Value))
                        Console.WriteLine("Day: " &amp; aggregate15)
                        Dim aggregate15a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate15a)
                        Dim aggregate15b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate15b)
                        Dim aggregate15c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate15c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      byyrqtr   Aggregate 16           
                    ' *****************************************************************************************************************
                    ' Fetch aggregate information about the opportunities that have 
                    ' been won by year and quarter.
                    Dim byyrqtr As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />" &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim byyrqtr_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byyrqtr))

                    For Each c In byyrqtr_result.Entities
                        Dim aggregate16d As Int32 = CInt(Fix((CType(c("year"), AliasedValue)).Value))
                        Console.WriteLine("Year: " &amp; aggregate16d)
                        Dim aggregate16 As Int32 = CInt(Fix((CType(c("quarter"), AliasedValue)).Value))
                        Console.WriteLine("Quarter: " &amp; aggregate16)
                        Dim aggregate16a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate16a)
                        Dim aggregate16b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate16b)
                        Dim aggregate16c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate16c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")
                    ' *****************************************************************************************************************
                    '                FetchXML      byyrqtr2   Aggregate 17           
                    ' *****************************************************************************************************************
                    ' Specify the result order for the previous sample.  Order by year, then quarter.
                    Dim byyrqtr2 As String = " " &amp; ControlChars.CrLf &amp; _
                        "                    <fetch distinct='false' mapping='logical' aggregate='true'> " &amp; ControlChars.CrLf &amp; _
                        "                        <entity name='opportunity'> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='opportunityid' alias='opportunity_count' aggregate='count'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_sum' aggregate='sum'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='estimatedvalue' alias='estimatedvalue_avg' aggregate='avg'/> " &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='quarter' alias='quarter' />" &amp; ControlChars.CrLf &amp; _
                        "                           <attribute name='actualclosedate' groupby='true' dategrouping='year' alias='year' />" &amp; ControlChars.CrLf &amp; _
                        "                           <order alias='year' descending='false' />" &amp; ControlChars.CrLf &amp; _
                        "                           <order alias='quarter' descending='false' />" &amp; ControlChars.CrLf &amp; _
                        "                           <filter type='and'>" &amp; ControlChars.CrLf &amp; _
                        "                               <condition attribute='statecode' operator='eq' value='Won' />" &amp; ControlChars.CrLf &amp; _
                        "                           </filter>" &amp; ControlChars.CrLf &amp; _
                        "                        </entity> " &amp; ControlChars.CrLf &amp; _
                        "                    </fetch>"

                    Dim byyrqtr2_result As EntityCollection = _serviceProxy.RetrieveMultiple(New FetchExpression(byyrqtr2))

                    For Each c In byyrqtr2_result.Entities
                        Dim aggregate17 As Int32 = CInt(Fix((CType(c("quarter"), AliasedValue)).Value))
                        Console.WriteLine("Quarter: " &amp; aggregate17)
                        Dim aggregate17d As Int32 = CInt(Fix((CType(c("year"), AliasedValue)).Value))
                        Console.WriteLine("Year: " &amp; aggregate17d)
                        Dim aggregate17a As Int32 = CInt(Fix((CType(c("opportunity_count"), AliasedValue)).Value))
                        Console.WriteLine("Count of all opportunities: " &amp; aggregate17a)
                        Dim aggregate17b As Decimal = (CType((CType(c("estimatedvalue_sum"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Sum of estimated value of all opportunities: " &amp; aggregate17b)
                        Dim aggregate17c As Decimal = (CType((CType(c("estimatedvalue_avg"), AliasedValue)).Value, Money)).Value
                        Console.WriteLine("Average of estimated value of all opportunities: " &amp; aggregate17c)
                        Console.WriteLine("----------------------------------------------")
                    Next c
                    Console.WriteLine("===============================")


                    Console.WriteLine("Retrieved aggregate record data.")

                    DeleteRequiredRecords(promptForDelete)

                End Using

            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
            Return
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a sample account record.
        ''' Create 3 opportunity records associate to the account record.
        ''' Mark all 3 opportunity records as won.
        ''' </summary>
        Public Sub CreateRequiredRecords()

            Dim OpportunityStatusCodes = New With {Key .Won = 3}

            ' Instantiate a account entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation
            ' to determine which attributes must be set for each entity.
            Dim setupAccount As Account = New Account With {.Name = "Example Account"}

            _accountId = _service.Create(setupAccount)

            Console.WriteLine("Created {0}.", setupAccount.Name)


            Dim setupCustomer As EntityReference = New EntityReference With {.LogicalName = Account.EntityLogicalName, .Id = _accountId}

            ' Create 3 sample opportunities.
            ' Instantiate opportunity entity records and set there property values.
            ' See the Entity Metadata topic in the SDK documentation
            ' to determine which attributes must be set for each entity.
            Dim setupOpportunities() As Opportunity = {New Opportunity With { _
                    .Name = "Sample Opp 1", .EstimatedValue = New Money With {.Value = 120000D}, .CustomerId = setupCustomer}, New Opportunity With { _
                    .Name = "Sample Opp With Duplicate Name", .EstimatedValue = New Money With {.Value = 240000D}, .CustomerId = setupCustomer}, _
                         New Opportunity With {.Name = "Sample Opp With Duplicate Name", .EstimatedValue = New Money With { _
                                 .Value = 360000D}, .CustomerId = setupCustomer}}

            _setupOpportunitiyIds = ( _
                From opp In setupOpportunities _
                Select _service.Create(opp)).ToArray()

            ' "Win" each of the opportunities
            For Each oppId As Guid In _setupOpportunitiyIds
                Dim winRequest As WinOpportunityRequest = New WinOpportunityRequest With { _
                    .OpportunityClose = New OpportunityClose With {.OpportunityId = New EntityReference With { _
                            .LogicalName = "opportunity", .Id = oppId}, .ActualEnd = New Date(2009, 11, 1, 12, 0, 0)}, _
                    .Status = New OptionSetValue(OpportunityStatusCodes.Won)}
                        ' Mark these entities as won in the year 2008 to 
                        ' have some testable results.
                _service.Execute(winRequest)
            Next oppId

            Console.WriteLine("Created {0} sample opportunity records and updated as won for this sample.", _setupOpportunitiyIds.Length)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                For Each oppId As Guid In _setupOpportunitiyIds
                    _service.Delete("opportunity", oppId)
                Next oppId

                _service.Delete("account", _accountId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New FetchAggregationAndGroupBy()
                app.Run(config, True)
            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
            ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main
    End Class
End Namespace

' </snippetfetchaggregationandgroupby>