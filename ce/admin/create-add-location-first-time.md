---
title: "Create or add a document location for the first time for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: ee3d48e4-aa07-47f5-ac09-5ee2b882dc69
caps.latest.revision: 29
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Create or add a document location for the first time

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Before you can manage documents for a record from [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], you must create a location record in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that points to libraries and folders on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] where the documents will be stored.  
  
1.  Open the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] record that has the documents you want to manage.  
  
2.  Under **Related**, click or tap**Documents**.  
  
3.  If a location isn’t associated, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] displays the **Add Document Location** dialog box or **Create [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] Location** dialog box. The following table shows the possible scenarios. Depending upon what you see, perform the steps in the “Next steps” column.  
  
|Scenario|What appears|Next steps|  
|--------------|------------------|----------------|  
|There is at least one site record in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that points to a site collection in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)], and the site record has the **List component is installed** check box selected.|**Add Document Location** opens with an option to specify either an absolute URL or a relative URL.|1.  In the **Name** box, verify or type the name. The document location record is created in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] with this name.<br />2.  In the **Document Location** box, enter the URL of the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] folder to which the location record points. This location is associated with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] record to store the documents.<br />     -  OR -<br />     Click or tap**Create a new folder**. In the **Parent Site or Location** box, click or tap the **Lookup** button ![Lookup button](../admin/media/lookup-button-4.gif "Lookup button") to select an existing document location record under which the folder will be created on [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. In the **Folder Name** box, verify or change the name, and click or tap**OK**. A folder with this name is created in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)].<br />3.  Click or tap**Save**.|  
|There is one site record in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] but the **List component is installed** check box is not selected.|**Add Document Location** appears with only the absolute URL option.|1.  In the **Name** box, verify or type a name. The document location record is created in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] with this name.<br />2.  In the **Document Location** box, enter the URL of the [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] folder to which the location record points. This location record is associated with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] record to store the documents.<br />3.  Click or tap**Save**.|  
|There is no existing location associated with the record, the URL specified in the **Document Management Settings** wizard is for a site collection on [!INCLUDE[pn_sharepoint_server_2010](../includes/pn-sharepoint-server-2010.md)] or [!INCLUDE[pn_sharepoint_server_2013](../includes/pn-sharepoint-server-2013.md)], and this site record has the **List component is installed** check box selected.|**Create [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] Location** appears.|[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] tries to automatically create a folder in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. If the folder is created successfully, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] opens **Create [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)] Location** with the URL of the new folder. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] creates a document location record that contains the URL of this new folder and associates the document location record with the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] record.<br /><br /> Click or tap**OK**.|  
  
 A new document location record is created in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] that contains the links to the folders in [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. The location that you just associated is added to the **Document Locations** list.  
  
### See also  
 [Create or edit document location records](../admin/create-edit-document-location-records.md)
