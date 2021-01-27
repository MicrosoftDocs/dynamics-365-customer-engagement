---
title: "Use the virtual entity OData v4 data provider | MicrosoftDocs"
description: "Learn how to use the Virtual entity OData v4 data provider"
ms.custom: 
ms.date: 01/14/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - powerapps
ms.assetid: 4cf0d6f6-870b-4ca6-80de-426494a8c2f5
caps.latest.revision: 
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---

# OData v4 Data Provider configuration, requirements, and best practices

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [OData v4 Data Provider configuration](/powerapps/maker/data-platform/virtual-entity-odata-provider-requirements)

This topic describes how to configure the OData v4 data provider as well as the requirements and recommended best practices for using the OData v4 data provider to connect with an OData v4 web service. 

## OData v4 data provider best practices

- Your instance requires that all entities have an ID attribute. This ID is known as a unique identifier and the value must be a guid.  You can only map ID fields to external fields with the EDM.Guid data type.  You can’t map an EDM.Int32 data type to a uniqueidentifer data type field.

- OData entities with nullable properties must be set to match the mapped field in the virtual entity. For example, an OData entity property with Nullable=False must have the mapped field with the Field Requirement attribute set to **Business Required**. 

- For retrieve multiple queries, such as when you load data in to a grid, control the size of the dataset returned from the external data source by using the select and filter query parameters.

- If not already enabled, system administrators should enable plug-in tracing. Once enabled, all errors from the OData endpoint are captured in the plug-in trace log. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [System Settings dialog box - Customization tab](../admin/system-settings-dialog-box-customization-tab.md) 

## Data type mapping

The following table lists the OData Entity Data Model (EDM) data type mappings with the appropriate data type. 


|  OData Data Type   | Data Type |
|--------------------|------------------------------------------------------------------|
|    Edm.Boolean     |                           Two Options                            |
|    Edm.DateTime    |                          Date and Time                           |
| Edm.DateTimeOffset |                          Date and Time                           |
|    Edm.Decimal     |                    Decimal Number or Currency                    |
|     Edm.Double     |                      Floating Point Number                       |
|      Edm.Guid      |                        Unique Identifier                         |
|     Edm.Int32      |                           Whole Number                           |
|     Edm.Int64      |                           Whole Number                           |
|     Edm.String     |          Single Line of Text or Multiple Lines of Text           |

### OData EDM data types that are not supported for mapping with virtual entities 
- Edm.Binary 

- Edm.Time 

- Edm.Float 

- Edm.Single 

- Edm.Int16 

- Edm.Byte 

- Edm.SByte


## Add a data source using the OData v4 Data Provider  
 This procedure shows you how to use the out-of-box OData Data Provider to use as the virtual entity data source.   

1. Go to **Settings** > **Administration** > **Virtual Entity Data Sources**.  

2. On the actions toolbar, select **New**.  

3. On the Select  Data Provider dialog box, select from the following data sources, and then select **OK**.  

   - **OData v4 Data Provider**. Your environment includes an Odata v4 data provider that can be used to connect to data sources that support the OData v4 open standard.  

   - *Custom data provider*. If you've imported a data  provider plug-in, the data provider will appear here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Get started with virtual entities](https://docs.microsoft.com/dynamics365/#pivot=developer&panel=developer_sales)  

4. On the New Data Source properties page, complete the following fields, and then save the record.  

   - **Name**. Type a name that describes the data source.  

   - **Uri**. If you are using the OData Data Provider, enter the uri for the OData web service. For example, if you are using the OData provider to connect to a web service hosted in Azure, the URI can look similar to *https://contosodataservice.azurewebsites.net/odata/*.  

   - **Timeout in seconds**. Enter the number of seconds to wait for a response from the web service before a data request time-out. For example, enter 30 to wait a maximum of thirty seconds before a time-out occurs.  

   - **Pagination mode**. Select whether to use client-side or server-side paging to control how query results are paged. The default value is client-side paging. With server-side paging, the server controls how results are paged by using the $skiptoken parameter, which is added to the query string. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Skip Token System Query Option ($skiptoken)](https://msdn.microsoft.com/library/dd942121.aspx)  
       -  **Return inline count**. Returns the total number records in the result set. This setting is used to enable next page functionality when you return data to a grid. Use a value of false if your OData endpoint doesn't support the OData $inclinecount parameter. The default value is false.

   - **Request Parameters**. Optionally, you can add custom header or query string parameters used to connect to the OData web service, such as authentication parameters to the external service. Select **Query String** to toggle between header and query string parameter and value. Up to 10 header or query strings can be added.  

   ![Virtual entity data source record](../customize/media/virtual-entity-data-source.png "Virtual entity data source record") 


### See also  

[Create and edit virtual entities that contain data from an external data source](create-edit-virtual-entities.md) <br/>
[TechNet Blog: Interact with data from external systems using the new virtual entities](https://blogs.technet.microsoft.com/lystavlen/2017/09/08/virtual-entities/)
