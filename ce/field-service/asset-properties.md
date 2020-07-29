---
title: "Asset properties | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 08/01/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Asset properties 

// https://msit.microsoftstream.com/video/1763a1ff-0400-a521-085b-f1eacb89ecd9?channelId=0bf6f71a-b361-4d7b-9668-62ff5207b60d
// keep in mind Dan talks about things in the video above that are not part of this feature but fetures later on that will be built on this capability. we dont want to cause confusion between what exists today and what is coming. 

## Prerequisites

Have one or more assets created in Field Service. For more informations see the topic on [Customer Assets](link)

## Create and assign asset categories


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-categories.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-categories-assign.png)

## Create property definitions


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-nav.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-form.png)

## Create templates for properties


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-templates-properties-only.png)


## Relate templates to asset categories, assets or both 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-templates.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-templates-specific-assets.png)

## Add property logs


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-log-create.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-log-lookup.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-log-lookup2.png)


### Manually add properties


**Asset record > Related > Property Asset Associations**

add property asset association

then go back to Properties tab and add a new property log 

the property you added will now show in the lsit of eligible properties


## Maintain property logs

+New Property Log


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-maintain.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-maintain-new-values.png)

> [!Note]
> You may have to refresh list


## Configuration considerations
## Additional Notes

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-templates-specific-assets.png)

//if its in asset subgrid itllshow in templates from asset from 
asset tempalte assciattions show sif you pick specific asset in tempalte


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-asset-template-associations.png)



The "Value" field in the property log shows the value of the asset property whether a string, number, boolean, or Date and Time. This value is not localized and is hidden by default on the property log form.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/assets-properties-maintain-new-values-callout.png)



