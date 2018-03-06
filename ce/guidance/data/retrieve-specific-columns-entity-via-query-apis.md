---
title: "Retrieve specific columns for an entity via query APIs | MicrosoftDocs"
description: "Queries submitted to retrieve data should include specific columns in the ColumnSet instance associated to the query rather than All Columns."
ms.date: 01/26/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: 752dae5d-0ac5-4f5b-b3bf-67d5abb0db46
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---
# Do not retrieve Entity all columns via query APIs

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Performance

**Impact potential**: High

<a name='symptoms'></a>

## Symptoms

Retrieving all columns can cause:

- Performance issues due to the amount of data being retrieved
- Unintended plugin/process execution

<a name='guidance'></a>

## Guidance

For optimal performance, you should only select the minimum amount of data needed by your application when querying [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] data. 

### ColumnSet Parameter

When you use the <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*> method set the `columnSet` parameter to a <xref:Microsoft.Xrm.Sdk.Query.ColumnSet> instance with specified columns.  When you use <xref:Microsoft.Xrm.Sdk.Query.QueryExpression> set the <xref:Microsoft.Xrm.Sdk.Query.QueryExpression.ColumnSet> property with the required attributes.

The following are some examples:

- [ColumnSet(param string[] columns)](/dotnet/api/microsoft.xrm.sdk.query.columnset.-ctor#Microsoft_Xrm_Sdk_Query_ColumnSet__ctor_System_String___) constructor overload for <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>.

    ```csharp
        var query = new QueryExpression("account")
        {
            ColumnSet = new ColumnSet("name", "address1_city")
        };

        var results = service.RetrieveMultiple(query);
    ```

- [ColumnSet(param string[] columns)](/dotnet/api/microsoft.xrm.sdk.query.columnset.-ctor#Microsoft_Xrm_Sdk_Query_ColumnSet__ctor_System_String___) constructor overload for <xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest>.

    ```csharp
        var entity = service.Retrieve("account", Guid.NewGuid(), new ColumnSet("name", "address1_city"));
    ```

- <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>.<xref:Microsoft.Xrm.Sdk.Query.ColumnSet.AddColumn(System.String)> method call.

    ```csharp
        var query = new QueryExpression("account");
        query.ColumnSet.AddColumn("name");
        query.ColumnSet.AddColumn("address1_city");

        var results = service.RetrieveMultiple(query);
    ```

- <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>.<xref:Microsoft.Xrm.Sdk.Query.ColumnSet.AddColumns(System.String[])> method call.

    ```csharp
        var query = new QueryExpression("account");
        query.ColumnSet.AddColumns("name", "address1_city");

        var results = service.RetrieveMultiple(query);
    ```

The following classes contain a <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>  instance:

- <xref:Microsoft.Crm.Sdk.Messages.ConvertQuoteToSalesOrderRequest>
- <xref:Microsoft.Crm.Sdk.Messages.GenerateInvoiceFromOpportunityRequest>
- <xref:Microsoft.Crm.Sdk.Messages.GenerateQuoteFromOpportunityRequest>
- <xref:Microsoft.Crm.Sdk.Messages.GenerateSalesOrderFromOpportunityRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveAllChildUsersSystemUserRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveBusinessHierarchyBusinessUnitRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveMembersTeamRequest>
- <xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveSubsidiaryTeamsBusinessUnitRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveSubsidiaryUsersBusinessUnitRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveTeamsSystemUserRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveUnpublishedRequest>
- <xref:Microsoft.Crm.Sdk.Messages.RetrieveUserSettingsSystemUserRequest>
- <xref:Microsoft.Crm.Sdk.Messages.ReviseQuoteRequest>
- <xref:Microsoft.Crm.Sdk.Messages.SearchByBodyKbArticleRequest>
- <xref:Microsoft.Xrm.Sdk.IOrganizationService>.<xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>
- <xref:Microsoft.Xrm.Sdk.Query.QueryExpression>

<a name='problem'></a>

## Problematic patterns

Queries that include a defined <xref:Microsoft.Xrm.Sdk.Query.ColumnSet> where the <xref:Microsoft.Xrm.Sdk.Query.ColumnSet.AllColumns> property is `true` instruct the platform to issue a SQL command to ["SELECT *"](https://technet.microsoft.com/library/ms189287.aspx) on all physical data included in the query plan.  This scenario should be avoided whenever possible.

> [!WARNING]
> These scenarios should be avoided.

- <xref:Microsoft.Xrm.Sdk.Query.ColumnSet>.<xref:Microsoft.Xrm.Sdk.Query.ColumnSet.AllColumns> setter method call.

    ```csharp
        var columns = new ColumnSet();
        columns.AllColumns = true;

        var query = new QueryExpression("account");
        query.ColumnSet = columns;

        var results = service.RetrieveMultiple(query);
    ```

- [ColumnSet(bool allColumns)](/dotnet/api/microsoft.xrm.sdk.query.columnset.-ctor#Microsoft_Xrm_Sdk_Query_ColumnSet__ctor_System_Boolean_) constructor overload.

    ```csharp
        var query = new QueryExpression("account")
        {
            ColumnSet = new ColumnSet(true)
        };

        var results = service.RetrieveMultiple(query);
    ```

- [ColumnSet(bool allColumns)](/dotnet/api/microsoft.xrm.sdk.query.columnset.-ctor#Microsoft_Xrm_Sdk_Query_ColumnSet__ctor_System_Boolean_) constructor overload for <xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest>.

    ```csharp
        var entity = service.Retrieve("account", Guid.Parse("bec45132-392a-4617-b935-a64ef04738e4"), new ColumnSet(true));
    ```

<a name='additional'></a>

## Additional information

Queries submitted to retrieve data from [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] should not select all columns.  Rather, specific individual columns should be specified in the <xref:Microsoft.Xrm.Sdk.Query.ColumnSet> instance associated to the query. Retrieving all columns for an entity can have a negative impact on performance. Additionally, you can unintentionally trigger plug-in registration events by retrieving columns you are not working with and issuing an update.

<a name='seealso'></a>

### See also

<xref href="Microsoft.Xrm.Sdk.Query.ColumnSet?text=ColumnSet Class" /><br />
[Use of the ColumnSet Class](../../developer/org-service/use-the-columnset-class.md)<br />
[Build queries with QueryExpression](../../developer/org-service/build-queries-with-queryexpression.md)<br />
[Use the QueryExpression Class](../../developer/org-service/use-queryexpression-class.md)<br />