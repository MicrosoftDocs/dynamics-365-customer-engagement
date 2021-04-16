---
title: "Modify the messages for an entity (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about editing the entity messages by exporting, editing, and importing translations."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - entities, updating entity display strings
  - modifying messages for entities, updating entity display strings
  - modifying messages for entities, editing text messages by exporting; editing; and importing translations
  - modifying messages for entities, manually editing entity messages
  - modifying messages for entities, customizing display names of system entities or attributes
  - entities, manually editing entity messages
  - text messages, editing by exporting; editing; and importing translations
  - entities, customizing display names of system entities or attributes
  - modifying messages for entities, editing messages so that they match your custom display names
  - messages, manually editing entity messages
  - messages, editing to match your custom display names
ms.assetid: ab9e81bc-d218-4438-8a09-cc64db08bb40
caps.latest.revision: 19
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Modify the messages for an entity

When you customize system entity or system attribute display names, some messages displayed by Dynamics 365 Customer Engagement (on-premises) will reference the default display names. Edit the default messages to match your customized display names.  
  
## Edit messages by exporting, editing, and importing translations

 You can edit text values for the base language exported by using the feature that allows for exporting and importing translations. When you export translations, you will download a compressed file. Extract the files and edit the CRMTranslations.xml file by using [!INCLUDE[pn_MS_Excel_Full](../includes/pn-ms-excel-full.md)]. You can edit display strings and localized labels. After editing the base language data in the exported file, you must compress the XRMTranslations.xml and [Content_Types].xml files and import them.
  
> [!NOTE]
>  You should evaluate each instance of the strings you want to change and look for variants that include uppercase letters or plural references. Avoid using a global find/replace.
  
## Manually edit entity messages

 For entity messages related to a specific entity, you can manually edit these messages in the entity customization user interface. You must save and publish each message and then publish customizations for your changes to be applied.

> [!NOTE]
> The messages displayed in the user interface for a particular entity may not include every instance of the entity name for that entity.  
  
 <!-- Remove the section below if Bug 700890 is not fixed -->

## Programmatically update entity display strings

 The display strings are stored in the `DisplayString` entity. Note this entity doesn’t contain the default display strings. The two attributes for this entity that contain text are `CustomDisplayString` and `PublishedDisplayString`. By default, these attribute values are `null` unless the display string has been customized.  
  
### See also

 [Customize Entity Metadata](customize-entity-metadata.md)   
 <!--Bug 700890 created to expose this in web api 
 [DisplayString Entity](entities/displaystring.md)   
 -->
 [Sample: Create and update entity metadata](/powerapps/developer/data-platform/org-service/create-custom-entity)   
 [Customize Labels to Support Multiple Languages](customize-labels-support-multiple-languages.md)   
 <xref:Microsoft.Crm.Sdk.Messages.ExportTranslationRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.ImportTranslationRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]