---
title: "Sample: Set and retrieve entity images (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
descriptions: The sample demonstrates how to set and retrieve data for entity images.
ms.custom: 
ms.date: 01/08/2020
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: fa9352f2-ef46-401f-b376-d0192c9f45a7
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer
search.app: 
  - D365CE
---
# Sample: Set and retrieve entity images

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Work with late bound entities](https://code.msdn.microsoft.com/Work-with-late-bound-e3208935). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to set and retrieve data for entity images.  
  
 The sample does the following tasks:  
  
1. Uses the `CreateImageAttributeDemoEntity` method to:  
  
   1.  Create a custom entity with the schema name `sample_ImageAttributeDemo` and a primary attribute with the schema name `sample_Name`.  
  
   2.  Create an image attribute with the schema name `EntityImage`. All image attributes use this name.  
  
   3.  Retrieve and update the main form for the `sample_ImageAttributeDemo` entity to set the `<form>` `showImage` attribute to `true` so that the image is displayed in the form.  
  
   4.  Publish the `sample_ImageAttributeDemo` entity.  
  
2. Creates five new records for the `sample_ImageAttributeDemo` entity using five different sized images located in the `Images` folder as shown here.  
  
   ![The relative size of source images](media/image-attribute-sample-before.png "The relative size of source images")  
  
    The `sample_Name` primary attribute field value is the name of the file.  
  
    After each record is created you have the opportunity to view the record in the web browser application using the `ShowEntityFormInBrowser` method so that you can see how the source images are resized to fit the space available in the form.  
  
   [!code-csharp[DynamicEntity#EntityImages2](../snippets/csharp/CRMV8/dynamicentity/cs/entityimages2.cs#entityimages2)]  
  
   > [!NOTE]
   >  This code uses late bound entities because the entity is created in the sample and is not available as a strongly typed class. However, after early bound classes are generated, the strongly typed classes could be used. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create Early Bound Entity Classes with the Code Generation Tool (CrmSvcUtil.exe)](org-service/create-early-bound-entity-classes-code-generation-tool.md)
  
3. Retrieves the records with the `entityimage` attribute and saves the resized files. After you run the sample you can find the files saved in the `\bin\Debug` folder.  
  
   [!code-csharp[DynamicEntity#EntityImages3](../snippets/csharp/CRMV8/dynamicentity/cs/entityimages3.cs#entityimages3)]  
  
    The image files are resized as shown here.  
  
   ![The relative size of downloaded images](media/image-attribute-sample-after.png "The relative size of downloaded images")  
  
4. Retrieves the records with the `entityimage_url` attribute and displays the relative URL values you can include in your application to access the images. This query should be more responsive because the amount of data transferred is smaller.  
  
   [!code-csharp[DynamicEntity#EntityImages4](../snippets/csharp/CRMV8/dynamicentity/cs/entityimages4.cs#entityimages4)]  
  
    The relative URLs will look something like the following examples:  
  
   -   /Image/download.aspx?Entity=sample_imageattributedemo&Attribute=entityimage&Id=2ed5a666-7b51-e311-9088-00155d9c5607&Timestamp=635205044273046819  
  
   -   /Image/download.aspx?Entity=sample_imageattributedemo&Attribute=entityimage&Id=22f17c6d-7b51-e311-9088-00155d9c5607&Timestamp=635205044320978850  
  
   -   /Image/download.aspx?Entity=sample_imageattributedemo&Attribute=entityimage&Id=24f17c6d-7b51-e311-9088-00155d9c5607&Timestamp=635205044333049824  
  
   -   /Image/download.aspx?Entity=sample_imageattributedemo&Attribute=entityimage&Id=26f17c6d-7b51-e311-9088-00155d9c5607&Timestamp=635205044343080227  
  
   -   /Image/download.aspx?Entity=sample_imageattributedemo&Attribute=entityimage&Id=28f17c6d-7b51-e311-9088-00155d9c5607&Timestamp=635205044353421800  
  
   The `DeleteImageAttributeDemoEntity` method gives you the option to delete the `sample_ImageAttributeDemo` entity and return your organization to state it was before running the sample. You can’t run the sample again until you delete this entity.  
  
## Example  
 The following is the full code for the sample.  
  
 [!code-csharp[DynamicEntity#EntityImages](../snippets/csharp/CRMV8/dynamicentity/cs/entityimages.cs#entityimages)]  
  
### See also  
 [Image Attributes](image-attributes.md)   
 [Introduction to entity attributes in Dynamics 365 Customer Engagement (on-premises)](introduction-entity-attributes.md)   
 [Introduction to Entities in Dynamics 365 Customer Engagement (on-premises)](introduction-entities.md)
