---
title: "Create and edit virtual entities with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn how to create virtual entities"
ms.custom: 
ms.date: 11/09/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 44834893-0bf6-4a64-8f06-7583fe08330d
caps.latest.revision: 11
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Create and edit virtual entities that contain data from an external data source

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Create and edit virtual entities that contain data from an external data source](/powerapps/maker/common-data-service/create-edit-virtual-entities)

A virtual entity is a custom entity in Dynamics 365 Customer Engagement (on-premises) that has fields containing data from an external data source. Virtual entities appear in your app to users as regular entity records, but contain data that is sourced from an external database, such as an [!INCLUDE[pn_Azure_SQL_Database_long](../includes/pn-azure-sql-database-long.md)]. Records based on virtual entities are available in all clients including custom clients developed using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)].  
  
 In the past, to integrate the disparate data sources you would need to create a connector to move data or develop a custom plug-in, either client or server-side. However, with virtual entities you can connect directly with an external data source  at runtime so that specific data from the external data source is available in an environmnent, without the need for data replication.  

Virtual entities are made up of three main components, a *data provider*, a *data source* record, and a *virtual entity*. The data provider consists of plug-ins and a data source entity. The data source is an entity record in Dynamics 365 Customer Engagement (on-premises), which includes metadata that represents the schema of the connection parameters. Each virtual entity references a data source in the entity definition.  
  
Dynamics 365 Customer Engagement (on-premises) includes an OData Data Provider that you can use to connect with an OData v4 web service that accesses the external data. 
  
Alternatively, developers can build their own data providers. Data providers are installed in an environment as a solution. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get started with virtual entities](../developer/virtual-entities/get-started-ve.md)
  
 ![Virtual entity diagram](../customize/media/virtual-entity-diagram.png "Virtual entity diagram")  
  
<a name="benefits"></a>   
## Virtual entity benefits  
  
- Developers can implement plugins to read external data using the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] and [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Plug-in Registration tool.  
  
- System customizers use Dynamics 365 Customer Engagement (on-premises) to configure the data source record and create virtual entities that are used to access external data without writing any code.  
  
- End users work with the records created by the virtual entity to view the data in fields, grids, search results, and Fetch XML-based reports and dashboards.  
  
<a name="AddDataSource"></a>   
## Add a data source to use for virtual entities  
 Developers create a custom plug-in to use as the data provider for a virtual entity. Alternatively, you can use the provided OData v4 Data Provider. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [OData v4 Data Provider configuration, requirements, and best practices](virtual-entity-odata-provider-requirements.md)  
  
1. Go to **Settings** > **Administration** > **Virtual Entity Data Sources**.  
  
2. On the actions toolbar, select **New**.  
  
3. On the Select  Data Provider dialog box, select from the following data sources, and then select **OK**.  
    
   - *Custom data provider*. If you've imported a data  provider plug-in, the data provider will appear here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get started with virtual entities](/dynamics365/?panel=developer_sales#pivot=developer)  
    
   - **OData v4 Data Provider**. Dynamics 365 Customer Engagement (on-premises) includes an OData Data Provider that can be used with OData v4 web services. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [OData v4 Data Provider configuration, requirements, and best practices](virtual-entity-odata-provider-requirements.md)
  
### Add a secured field to a Data Source
You create fields for a Data Source in the same way as any other entity. For data that is encrypted or sensitive, enable the Data Source Secret attribute on the custom field of the Data Source. For example, to secure a field that contains a database connection string. 

> [!NOTE]
> The Data Source Secret attribute is only available with fields added to a Data Source form.

![Data source secret attribute](../customize/media/datasourcesecret.png)
  
<a name="createVirtualEntity"></a>   
## Create a virtual entity  
  You create a virtual entity just like any other entity in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] with the addition of a few extra attributes described here.

> [!NOTE]
>  Although you can create a virtual entity by selecting **None** as the data source, to acquire data a virtual entity requires a data source. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Add a data source to use for virtual entities](#AddDataSource)  
  
1. Go to **Settings** > **Customizations** > **Customize the System**.  
  
2. In the solution explorer, create a new entity. To do this, select **Entities** in the left navigation pane, and then select **New**.  
  
3. On the **General** tab of the **Entity Definition**, select **Virtual Entity**, and then in the **Data Source** drop down list, select the data source that you want.  
  
   ![Virtual Entity option on entity definition](../customize/media/virtual-entity-click-option.png "Virtual Entity option on entity definition")  
  
4. On the Entity Definition, complete the following required fields.  
  
   - **External Name**. Enter the name of the table in the external data source this entity maps to.  
  
   - **External Collection Name**. Enter the plural name of the table in the external data source this entity maps to.  
  
     Here's an example of a virtual entity named *Movie* that uses a Azure Cosmos DB data provider to access document files.  
  
   ![Virtual entity definition using the Azure Cosmos DB data provider](../customize/media/virtual-entity-definition.PNG "Virtual entity definition using the Azure Cosmos DB data provider")  
  
   > [!IMPORTANT]
   > Several options, such as Access Teams, Queues, and Quick Create,  aren't available with virtual entities. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Considerations when you use virtual entities](#considerations)  
   
   Complete the additional required and optional properties, such as display and plural names, as necessary. For more information about these properties, see [Create and edit entities](../customize/create-edit-entities.md).  
  
5. Create and add one or more fields for the virtual entity. In addition to the standard field properties required to create a custom field, these optional properties are available for each custom field you create for a virtual entity.  
  
   - **External Name**. This is typically the unique name to identify the data  you want to display in the field.  
  
   > [!NOTE]
   >  If the field type you create is OptionSet, the following additional fields are available.  
   >   
   > - **External Type Name**. This property maps to the external name of the set of values in the external service for the option set.  Typically, this can be an enum or name of a string value class. The External Type Name can be used when a fully qualified name is required.  For example, as the *Type Name* with OData where parameters in a query need the fully qualified name, such as [*Type Name*].[*Value*].  
   > - **External Value**. This property maps to the corresponding value in the external data source for the option set item.  This value entered is used to determine which option set item to display in the app.  
  
    Complete the additional properties as necessary. For more information about these properties, see [Create and edit fields](../customize/create-edit-fields.md).  
  
6. Select **Save and Close** on the **Field** properties page.  
  
7. On the solution explorer toolbar, select **Save**.  
  
8. On the solution explorer toolbar, select **Publish**.  
  
9. Close solution explorer.  

<a name="considerations"></a>   
## Considerations when you use virtual entities  
 Virtual entities have these restrictions.  
  
- All virtual entitites are read-only.  

- Existing entities cannot be converted to virtual entities.  

- By default, virtual entities contain only a Name and Id field.  No other system managed fields, such as Status or Created On/Modified On are supported.

- Virtual entities don't support custom fields with the Currency, Image, or Customer data types.
  
- Virtual entities don't support auditing.  

- Virtual entity fields can't be used in rollups or calculated fields.
  
- A virtual entity can't be an activity type of entity.  
  
- Many features that affect entity table rows cannot be enabled with virtual entities.  Examples include queues, knowledge management, SLAs, duplicate detection, change tracking, mobile offline  capability, field security, Relevance Search, Portals for Dynamics 365 Customer Engagement (on-premises) web portal solutions, and N:N relationships between virtual entities.  
  
- Virtual entities are organization owned and don't support the row-level Commond Data Service for Apps security concepts. We recommend that you implement your own security model for the external data source.  
  
- We recommend that you target a single data source when you use virtual entities in Advanced Finds. For example, creating an  Advanced Find that ultimately creates a join between the Dataverse native data and the virtual entity external data isn't supported.  
   
- Field metadata properties that validate on update don’t apply to virtual entities. For example, a Whole Number field on a virtual entity field may be set to have a minimum value of zero. However, since the value is coming from an external data source, a query will return values less than zero when retrieved from a virtual entity.  The minimum value property is not implied in the query.  You would still need to filter the values to be greater than 0 if that’s what is desired.

- Virtual entities don't support change tracking and cannot be synchronized by using a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] feature, such as the [!INCLUDE [cc-data-export-service](../includes/cc-data-export-service.md)].
  
### See also  

[OData v4 Data Provider requirements and best practices](virtual-entity-odata-provider-requirements.md)</br> 
[Create and edit entities](../customize/create-edit-entities.md)</br>
[Create and edit fields](../customize/create-edit-fields.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]