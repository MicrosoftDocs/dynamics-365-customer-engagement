---
title: "Configure mobile offline profiles for files and images| MicrosoftDocs"
ms.custom: 
description: Configure mobile offline profiles for files and imagese for Dynamics 365 phones and tablets app and Power Apps mobile.
ms.date: 10/15/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
caps.latest.revision: 1
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---

# Configure mobile offline profiles for files and images


You need to add additional tables and relationships to work with files and images while being offline. This should be considered when the profile contains tables with columns of type file or image.
Note! The maximum size for files and images is defined in column settings under Advanced options in Power Apps for columns where Data type = Image.


> [!IMPORTANT]
> To use this feature an administrator must to set up mobile offline for their organization. The set up and configuration process for mobile offline is the same for [Power Apps mobile](/powerapps/mobile/run-powerapps-on-mobile) and Dynamics 365 for phones and tablets app. To enable mobile offline synchronization for Power Apps mobile or Dynamics 365 mobile, follow the steps in this article.


1. Sign in to [Power Apps](https://make.powerapps.com).

  
2. On the left nav select **Data** to expand it and then select **Tables**.  

   > [!div class="mx-imgBorder"]
   >![Go to tables.](media/maker-data-tables.png "Go to tables")
   
