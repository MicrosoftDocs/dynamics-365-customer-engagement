---
title: "View the fields that are synchronized between Customer Engagement (on-premises) and Outlook | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: view-fields-synchronized-dynamics-365-outlook
caps.latest.revision: 18
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# View the fields that are synchronized between Customer Engagement (on-premises) and Outlook

In [!INCLUDE[pn_crm_2015_outlook](../includes/pn-crm-2015-outlook.md)] or later, you can view the appointments, contacts, and tasks fields that are synchronized between Dynamics 365 Customer Engagement (on-premises) and [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] so you can see where the data is coming from. You can also determine whether the fields:  

- Are synchronized one way (from [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] to Customer Engagement (on-premises) **or** from Customer Engagement (on-premises) to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)])  

- Are synchronized two way (from [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] to Customer Engagement (on-premises) **and** from Customer Engagement (on-premises) to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)])  

- Aren’t synchronized  

  For example, if the fields are synchronized one way, from Customer Engagement (on-premises) to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)], you can update the field in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] and save the change, but your changes won’t be synced with Customer Engagement (on-premises), and will be overwritten if the same field value is changed in Customer Engagement (on-premises). So if fields are synced one way, there’s no need to change the value in the synchronized field.  

## View the synchronized fields  

1. In the web app, in the upper-right corner of the screen, click the **Settings** button ![User profile Settings button](../../../outlook-app/media/priv-user.gif "User profile Settings button") > **Options**.  

2. In the **Set Personal Options** dialog box, choose the **Synchronization** tab.    

3. Choose **synchronized fields**.  

4. In the **Synchronization Settings for [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]** dialog box, click the **Synchronization Fields** tab.  

   ![Field-level Sync tab](media/field-level-sync-tab.png "Field-level Sync tab")  

5. In the **Entity Type** list, select the record type you want to view.  

   [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] fields are displayed on the left and the corresponding Customer Engagement (on-premises) fields are displayed on the right. The blue arrows show the sync direction:  


   | This indicator        | Shows that the fields      |
   |------------|---------------|
      | ![One-way sync arrow (right) in Dynamics 365 for Customer Engagement](media/one-way-sync-arrow-right.png "One-way sync arrow (right) in Dynamics 365 for Customer Engagement") | Are synced one way from [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] to Customer Engagement (on-premises) |
   |  ![One-way sync arrow (left) in Dynamics 365 for Customer Engagement](media/one-way-sync-arrow-left.png "One-way sync arrow (left) in Dynamics 365 for Customer Engagement")   | Are synced one way from Customer Engagement (on-premises) to [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] |
   |            ![Two-way sync arrow in Dynamics 365 for Customer Engagement](media/two-way-sync-arrow.png "Two-way sync arrow in Dynamics 365 for Customer Engagement")            |                                                                  Are synced two way                                                                  |
   |       ![No synchronization arrow for Dynamics 365 for Customer Engagement](media/no-sync-arrow.png "No synchronization arrow for Dynamics 365 for Customer Engagement")        |                                                                    Aren’t synced                                                                     |

   > [!NOTE]
   >  Field synchronization direction can be impacted by security settings configured by your system administrator. For example, if you don’t have read privileges for a field, it won’t be synchronized in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] even if the field is configured for two-way synchronization. To determine whether you have read privileges for a field, click the **View in Customer Engagement (on-premises)** button to open the record in Customer Engagement (on-premises). If you see the **Lock** icon, you can’t access the field.  

### See also  
 [Frequently asked questions about synchronizing records between Customer Engagement (on-premises) and Microsoft Outlook](frequently-asked-questions-synchronizing-records-dynamics-365-and-outlook.md)   
 [What fields can be synchronized between Customer Engagement (on-premises) and Outlook or Exchange?](what-fields-synchronized-outlook.md)   
 [Control field synchronization between Customer Engagement (on-premises) and Outlook or Exchange (admins)](control-field-synchronization-outlook.md)   
 [How security affects synchronization between Customer Engagement (on-premises) and Outlook or Exchange](how-field-security-affects-synchronization-between-outlook.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]