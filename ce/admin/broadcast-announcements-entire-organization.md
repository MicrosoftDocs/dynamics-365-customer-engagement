---
title: "Broadcast announcements to an entire organization for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: edde6952-7a42-4c59-8d7b-8553f302e01b
caps.latest.revision: 40
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Broadcast announcements to an entire organization
Circulate information quickly to a wide set of users at one go by using **Announcements** in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Announcements can also serve as message boards, where you can post topics of your interest that you wish to share, or get answers to.  
  
## Create an announcement  
 Use the **Announcements** page to create and broadcast an announcement.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_system](../includes/proc-settings-system.md)]  
  
3.  Choose **Administration** > **Announcements** .  
  
4.  On the command bar, choose **New**.  
  
5.  Fill in the information, as required. Use the handy tooltips as a guide.  
  
    - **Title** - Type a title for the announcement that clearly and unambiguously states the purpose and nature of the announcement.  
  
    - **Body** - Type the text for the announcement that you want to broadcast.  
  
        > [!TIP]
        >  You can copy and paste an announcement text from another application. However, formatting might be lost.  
  
    - **More Information URL** - Type the address of the website that provides detailed information about the announcement. (Optional)  
  
        > [!NOTE]
        >  A web address that does not contain "http://" is automatically expanded to a full web address. In the announcement, the web address will appear as an active external link.  
  
    - **Expiration Date** - Type the date on which you want to stop the broadcast and the announcement should expire.  
  
        > [!NOTE]
        >  You can’t edit/extend this date after expiry. [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] deletes the announcement after the expiration date.  
  
6.  When you’re done, on the command bar, choose **Save** or **Save and Close** to begin the broadcast.  
  
## Broadcast an announcement  
 Make the announcements available to other users in your organization by using web resources and dashboards.  
  
### Create a web resource  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2.  In a text editor, type the following code, and save the file as “announcementsondashboard.htm”.  
  
     `<html>`   
     `<body>`   
     `<script type="text/javascript">window.location.href="/home/homepage/home_news.aspx?pagemode=iframe";</script>`   
     `</body>`   
     `</html>`  
  
3.  In [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], go to **Settings** > **Customization** > **Customize the System**.  
  
4.  Under **Components**, choose **Web Resources** > **New**.  
  
5.  Type the name as “announcements” and display name as “Announcements”.  
  
6.  In the **Type** drop-down list, select **Web Page (HTML)**.  
  
7.  In the **Upload File** box, choose **Browse** and select the “announcementsondashboard.htm” file that you created earlier.  
  
8.  Choose **Save**.  
  
9. Add this new web resource to any existing or new dashboard.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [eBook: Create or customize CRM system dashboards](http://go.microsoft.com/fwlink/p/?LinkID=400662)  
  
### See also  
 [MSDN: Understand dashboards: Dashboard components and FormXML](https://msdn.microsoft.com/library/gg334200.aspx)