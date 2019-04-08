---
title: "Troubleshoot SharePoint Online setup | MicrosoftDocs"
ms.custom: 
ms.date: 04/05/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 28ba29c2-a661-4d6e-b72a-47c69a94de98
caps.latest.revision: 7
author: jimholtz
ms.author: jimholtz
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Troubleshoot SharePoint Online setup

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

If you see the following error message... [need screenshots]

## Validate and fix Related - Documents link/button missing

Start by understanding the requirements listed in [Important considerations for server-based SharePoint integration](important-considerations-server-based-sharepoint-integration.md).

1. Make sure you have the System Administrator security role or equivalent permissions in Dynamics 365 for Customer Engagement.
    Check your security role:
    1. Follow the steps in [View your user profile](../basics/view-your-user-profile.md).
    2. Don’t have the correct permissions? Contact your system administrator.

2. Fix the missing **Documents** button. Follow these steps:

   1. Identity the entity for which the documents link should be visible (e.g. account, contact, opportunity...etc.).
   2. Go to **Settings** > **Document Management Settings**.
   3. Make sure the entity you wished to have documents link (selected in Step 1) are selected and a valid SharePoint URL is specified. 
   4. Complete the wizard.
   5. Verify if the Documents link /button is appearing.

## Validate and fix Related - Missing Document associated grid

Start by understanding the requirements listed in [Important considerations for server-based SharePoint integration](important-considerations-server-based-sharepoint-integration.md).

The most common cause for *Documents Associated Grid not to load* is the corrupted FetchXML and LayoutXML. These sections could be corrupted due to many reasons. The most common of them is through customizing the entity/grid view, adding/removing columns, and other similar customizations.

To fix *Documents Associated grid not loading*, follow these steps:

1. Go to Settings-> Customizations -> Solutions -> create a solution (named SharePointDocumentSolution) -> add SharePoint Document Entity (select all fields , forms, views)
2. Save and close
3. Publish All customizations.
4. Select the created (SharePointDocumentSolution) solution.
5. Export the solution. (SharePointDocumentSolution.zip will be downloaded) 
6. Extract the zip file (downloaded file from step “e”)
7. Browse the folder, Locate and Open customization.xml
8. Search LayoutXml of Document Associated Grid(search for Document Associated)
9. Make the changes as below.

```  
<grid name="sharepointdocument" object="9507" jump="fullname" select="1" icon="0" preview="1">
<row name="sharepointdocument" id="sharepointdocumentid">
<cell name="fullname" width="300" imageproviderfunctionname="DocumentManagement.FileTypeIcon.loadSharePointFileTypeIcon" imageproviderwebresource="$webresource:SharePoint_main_system_library.js" />
<cell name="modified" width="150" />
<cell name="sharepointmodifiedby" width="150" />
<cell name="servicetype" width="150" />
<cell name="relativelocation" width="200" />
<cell name="documentid" ishidden="1" />
<cell name="title" ishidden="1" />
<cell name="author" ishidden="1" />
<cell name="sharepointcreatedon" ishidden="1" />
<cell name="sharepointdocumentid" ishidden="1" />
<cell name="filetype" ishidden="1" />
<cell name="readurl" ishidden="1" />
<cell name="editurl" ishidden="1" />
<cell name="ischeckedout" ishidden="1" />
<cell name="absoluteurl" ishidden="1" />
<cell name="locationid" ishidden="1" />
<cell name="iconclassname" ishidden="1" />
</row>
</grid>
```  

10. Make the changes as below for the FetchXml section.

```  
<fetch distinct="false" mapping="logical">
  <entity name="sharepointdocument">
  <attribute name="documentid" />
  <attribute name="fullname" />
  <attribute name="relativelocation" />
  <attribute name="sharepointcreatedon" />
  <attribute name="ischeckedout" />
  <attribute name="filetype" />
  <attribute name="modified" />
  <attribute name="sharepointmodifiedby" />
  <attribute name="servicetype" />
  <attribute name="absoluteurl" />
  <attribute name="title" />
  <attribute name="author" />
  <attribute name="sharepointdocumentid" />
  <attribute name="readurl" />
  <attribute name="editurl" />
  <attribute name="locationid" />
  <attribute name="iconclassname" />
  <order attribute="relativelocation" descending="false" />
  <filter>
  <condition attribute="isrecursivefetch" operator="eq" value="0" />
  </filter>
  </entity>
  </fetch>
```  

11. Save the file.
12. Zip the folder.
13. Open Dynamics.
14. Navigate to **Settings** > **Solutions**
15. Import the solution (zipped file in Step 12).
16. Publish all customizations.
17. Verify the Document associated grid is displaying in all the required SharePoint documents.


