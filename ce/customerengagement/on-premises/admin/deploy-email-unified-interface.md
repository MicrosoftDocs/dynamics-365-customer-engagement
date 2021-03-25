---
title: "Enable accessible email  | MicrosoftDocs"
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
ms.assetid: bc0377a3-db62-4d0d-9531-a12dc01d1d0c
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin
---
# Enable accessible email flow

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

To improve accessibility when reading and editing email in Dynamics 365 Customer Engagement (on-premises), we're introducing an app that provides an accessible email flow. This topic explains how admins can enable this flow and how end users can access it.

## For admins: Install the app

Follow these steps to deploy the solution and enable users to use the accessible flow.

**Install the app**

1. [!INCLUDE[proc_office365_signin](../includes/proc-office365-signin.md)] You can also sign in with Customer Engagement (on-premises) system administrator or delegated admin security roles.  
  
2. Select **Admin centers** > **Dynamics 365**.  

3. Select the **Instances** tab, select the instance to add the app to, and then select **Manage your solutions** ![Manage your solutions](media/manage-solution.png "Manage your solutions").

4. Select the **Email in Unified Interface** app, and then select **Install**.  

You can now see the app in the list of published apps. Go to **Settings** > **My Apps** to see it.

![Email Unified Interface app published](media/email-unified-interface-app-published.png "Email Unified Interface app published")

**Provide users with permissions for the accessible email access flow**

For users who want to have accessible email access, follow these steps.

1.  Go to **Settings** > **Security** > **Users**.  
  
2.  In the list, select the user or users that you want to assign a security role to.  
  
3.  Select **Manage Roles**.  
  
    Only the security roles available for a user's business unit are displayed.  
  
4.  In the **Manage User Roles** dialog box, select the **Email app access role** security role, and then select **OK**.  

**Notify users**

Once the app is installed, notify users that they need to reload the web application to see and use the accessible email flow.

## For end users: Use the accessible email flow

Users with the **Email app access role**, go to **Sales**, **Service**, or **Marketing**. Select **Email Messages** to open emails.

> [!NOTE]
> - If you don't see **Sales**, **Service**, or **Marketing**, your Customer Engagement (on-premises) has been customized. Talk to your administrator or customizer.
> - **Email Messages** will not appear if **Activities** has been customized to not be included in the sitemap.

![Select Email Messages](media/select-email-messages75.png "Select Email Messages")

Here, you can read and manage your emails in the Email in Unified Interface app.

![Email for Unified Interface](media/email-for-unified-interface.png "Email for Unified Interface")

### See also




[!INCLUDE[footer-include](../../../includes/footer-banner.md)]