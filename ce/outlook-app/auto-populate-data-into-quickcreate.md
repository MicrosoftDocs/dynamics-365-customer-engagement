---
title: " Customize App for Outlook to auto populate data from an Outlook item to a quick create case table (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description:  Customize App for Outlook to auto populate data from an Outlook item to a quick create case table in Dynamics 365 App for Outlook.
ms.date: 04/29/2021
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Customize App for Outlook to auto populate data from an Outlook item to a quick create case table 

Use the quick create form in App for Outlook to auto populate information from an Outlook item to the quick create form for the Case entity. You can only enable the quick create option for the case entity. 

![Demo of how to create a case table using quick create](media/email-to-case.gif)



These fields that will be populated automatically:

|                                                                                                |                                                                                              |                                                                                      |
|------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------|
|                                          **Outlook item field**                                           |  | **Quick Create Case form field** |
|                             Email sender                                |                                             Mapped to ->                                              |                                         Contact                                          |
|                            Email/appointment subject                            |                                              Mapped to ->                                              |                                         Case Title                                          |
|                              Currently selected contact (if known)                              |                                             Mapped to ->                                              |                                         Contact                                          |
|                              Email                                |                                               Mapped to ->                                               |                                         Origin                                          |
|                                   Email body                                     |                                              Mapped to ->                                              |                                          Description                                        |



## Enable quick create for a case table

1. From your app, go to **Settings** > **Advanced Settings**.

   > [!div class="mx-imgBorder"]
   >![Setting Customizations](media/outlookapp_advancedsettings.png "Settings Customizations")
  
2. Select **Settings** > **Customizations** and then select **Customize the System**.  

   > [!div class="mx-imgBorder"]
   >![Select a Customize the System](media/outlookapp_customize.png "Customize the System")

3.	Expand **Entities** and then select the **Case** entity.
4.	Expand the entity and select **Forms**, then select **Form Order** and  **Quick Create Form Set**.
5.	Ensure that **App for Outlook Case Quick Create** form is at the top of the list, for it to be used for quick create scenario and then select **OK**.

    > [!div class="mx-imgBorder"] 
    > ![App for Outlook Case Quick Create form](media/outlookapp_qcf.png "App for Outlook Case Quick Create form")
   
6.	On the solution page, select **Publish All Customizations** and then close the page.


## Use quick create to create a case 

1. Open an email item that you want to create a case entity for and then select the **Dynamics 365** button. 
2. On the **Dynamics 365** pane, select ![Quick Create](media/outlookapp_quickcreate.png "Quick Create form") **Quick Create** > **Case**.

    The information from the Outlook item will auto populate in the case form.

3. When you're done, select **Save and Close**. 



[!INCLUDE[footer-include](../includes/footer-banner.md)]
