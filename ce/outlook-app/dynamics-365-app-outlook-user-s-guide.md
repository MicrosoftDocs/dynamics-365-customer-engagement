---
title: "Dynamics 365 App for Outlook User Guide (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: How to use Dynamics 365 App for Outlook.
ms.date: 02/26/2020
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
# Dynamics 365 App for Outlook User Guide  

Use [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] to tap the power of your Dynamics 365 apps while you’re using [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] on the desktop, web, or phone. When [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] is installed, depending on which version of  the app you have installed, you'll see a **Dynamics 365** pane or window next to a selected [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email message, or when you're composing an email message or setting up a meeting or appointment.  

> [!IMPORTANT]
> - The latest release of [!INCLUDE[pn_ms_dyn_crm_app_for_outlook](../includes/pn-ms-dyn-crm-app-for-outlook.md)] works with customer engagement apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation), [Dynamics 365 Customer Engagement (on-premises), version 9](../customerengagement/on-premises/overview.md), and [Microsoft Dataverse](/powerapps/maker/common-data-service/data-platform-intro).
> - For a prior release that works with earlier versions of Dynamics 365 apps, see [Deploy Dynamics 365 App for Outlook](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn946901(v=crm.8)).

 For example, when you open an email message, view information from your Dynamics 365 app about the email recipients. Or with a single click, link an [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] email message or appointment to a specific Dynamics 365 record. When you link an email message or appointment to a Dynamics 365 record, the [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] record appears as an activity for that record in Dynamics 365 apps.  

 <!--[Watch a short video (1:35) about Dynamics 365 App for Outlook.](https://go.microsoft.com/fwlink/p/?linkid=829982)  -->

## FAQs

For more information on FAQs, see [Frequently Asked Questions about Dynamics 365 App for Outlook](faq.md).

## Prerequisites  
 Your system administrator can make [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)] available to your organization or you can add it yourself if:  

- You have the **Use [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]** security privilege.  

- Your organization synchronizes mailboxes with server-side synchronization.  

  For more information, and for information on supported devices, browsers, and [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] versions, see [Deploy Dynamics 365 App for Outlook](deploy-dynamics-365-app-for-outlook.md).  

## Add the app to Outlook  
 After the prerequisites have been met, you can add the app directly from Dynamics 365 app.  

1. Select the **Settings** button ![Dynamics 365 apps web client Settings button](../outlook-app/media/mp-ua-r16-settings.png "Dynamics 365 apps web client Settings button"), and then click **Apps for Dynamics 365**.  

2. On the **Apps for Dynamics 365** page, under **[!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]**, click **[!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)]**.  

   > [!NOTE]
   > If you have trouble installing  the app, see the troubleshooting section in [Deploy Dynamics 365 App for Outlook](deploy-dynamics-365-app-for-outlook.md).  



### Create a new record  

1. Click **Quick Create**, and then select the type of record you want to create.  

   ![Add new record](media/navbar-add.png)  

2. Fill in the information in the form.  

   ![Create new record in Quick Create form](media/create-account.png)  

3. Click **Save**.  

### View the linked email in Dynamics 365 apps

1. Find the linked record in a list or using Search. 

2. In Tracked regarding, click (...) > **View email in Dynamics 365 apps**.

   ![View email in Dynamics 365 apps](media/view-email-dynamics-365.png)


### Untrack the regarding record  

1. Find the record to link in a list or using Search. 

2. In Tracked regarding, click (...) > **Untrack**.

   ![Untrack Regarding](media/open-untrack-regarding.png)


 ### Monitor an email message  

1.  Create an email message as you normally would in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)].  

2.  Track the email message or link it to a record in Dynamics 365. You can’t monitor an email message unless you track it or link it (set a regarding record).  

3.  In the **Dynamics 365** pane, click **Follow**, and then click **Follow this email**.  

 ![Follow email in Dynamics 365 for Outlook](../outlook-app/media/follow-email-dynamics-365-outlook.png "Follow email in Dynamics 365 for Outlook")  

   > [!NOTE]
   >  Any recipients that can’t be followed will be displayed at the bottom of the **Dynamics 365** pane.  

4.  Send the message in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)].  

    > [!IMPORTANT]
    >  Do not edit the email message or change the recipients after you follow it. If you edit an email message after it’s followed, you may inadvertently delete the monitoring information or you may inadvertently add recipients who shouldn’t be followed.  


### Remove the monitoring for an email message  

1.  Select the monitored email message.  

2.  Click **Unfollow**.  -->
  
   
## Track appointments from another person in your organization

You can track appointments from another person in your Dynamics 365 apps organization using Dynamics 365 App for Outlook. To enable this capability, you need to enable the OrgDBOrgSetting in your organization. Dynamics 365 apps provides the OrgDBOrgSettings tool that gives administrators the ability to implement specific updates that were previously reserved for registry implementations.

1. Follow the instructions [in this article](https://support.microsoft.com/help/2691237/orgdborgsettings-tool-for-microsoft-dynamics-crm) for steps to extract the tool.
2. After extracting the tool, enable the *OrgDBOrgSetting TrackAppointmentsFromNonOrganizer*.

You can also use [this tool](https://github.com/seanmcne/OrgDbOrgSettings/releases/) to edit the *OrgDBOrgSetting TrackAppointmentsFromNonOrganizer*.

After the *OrgDBOrgSetting* is enabled, when you open Dynamics 365 App for Outlook on an appointment created by another user in your organization, you can track the appointment. You will no longer see the banner blocking you from tracking the calendar item.

 ![Track appointments](media/Trackappointments.png "Track appointments ")

## Synchronization and tracking 

The Dynamics 365 App for Outlook tracks and synchronizes your mail and calendar data between Outlook (Exchange) and Dynamics 365 apps. Server Side Synchronization is an asynchronous service that runs in the background approximately every 15 minutes to synchronize items between Exchange and Dynamics 365 apps. In most scenarios, the Outlook item is immediately created in Dynamics 365 apps. However, in some cases, Server Side Synchronization service is used to promote the item to Dynamics 365 apps and keep it synchronized, which may take up to 15 minutes. The below table provides a brief explainer of the behavior.

In most cases items are immediately tracked, aside from when an email is in compose mode and recurring appointments.

   > [!NOTE]
   > Server Side Synchronization is used to promote emails when Microsoft Outlook includes images in email signatures as attachments.

If the Dynamics 365 App for Outlook uses Server Side Synchronization to track an item to Dynamics 365 apps, the track status of the item will be “Pending”.

![Outlook app server side sync](media/Outlook_app_server_side_sync.png "Outlook app server side sync")

   > [!NOTE]
   > For manually tracked items, App for Outlook only synchronize pre-definded fields between Outlook (Exchange) and Dynamics 365 apps. Any [Field level synchronization settings](/power-platform/admin/what-fields-synchronized-outlook) will have no effect while tracking the items manually from App for Outlook.
   
### See also  
 [Deploy Dynamics 365 App for Outlook](deploy-dynamics-365-app-for-outlook.md)   
 [Set up server-side synchronization (admins)](/power-platform/admin/set-up-server-side-synchronization-of-email-appointments-contacts-and-tasks)   



[!INCLUDE[footer-include](../includes/footer-banner.md)]
