---
title: Enable Service Agent in Microsoft 365 Copilot (preview)
description: Learn how to enable Service Agent in Microsoft 365 Copilot so customer service representatives can use Copilot to get responses on case and customer records without manually searching for the information.
ms.date: 03/31/2026
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
---

# Enable Service Agent in Microsoft 365 Copilot (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

Service Agent extends Microsoft 365 Copilot with customer service-specific capabilities. Service Agent enables Microsoft 365 Copilot to retrieve and reason over customer service data, such as cases, customer records, and recent interactions, when customer service representatives ask Copilot questions or request assistance.
  
After you enable Service Agent, representatives can use Copilot to get responses based on relevant service information—such as cases or customer records—without manually searching for the data.
  
Representatives can also access Service Agent directly in Copilot Service workspace while working on customer interactions to retrieve relevant service information in-context

## Enable Service Agent

To enable Service Agent in Dynamics 365 Customer Service, there are two key steps that are required:

1. The tenant administrator must [enable and install the Service in Microsoft 365 Copilot app](#enable-and-install-service-in-microsoft-365-copilot-app) that contains Service Agent.
1. The Dynamics organization administrator must [add the Microsoft 365 Copilot application to the Dynamics environment](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

After you enable Service Agent, service representatives in your organization can use the agent in Microsoft 365 Copilot chat and in the Copilot Service workspace app.

## Enable and install Service in Microsoft 365 Copilot app

Service in Microsoft 365 Copilot is an app that integrates with Dynamics 365 Customer Service and uses AI to help customer service representatives work more efficiently. It provides features that make common customer service tasks, such as saving Outlook interactions to your customer relationship management (CRM) system, viewing email and case summaries, and drafting responses, faster and easier.

You can install Service in Microsoft 365 Copilot from [Microsoft Marketplace](https://marketplace.microsoft.com/) and [Microsoft Teams](https://support.microsoft.com/office/add-an-app-to-microsoft-teams-b2217706-f7ed-4e64-8e96-c413afd02f77).

### Prerequisites

Before you can install Service in Microsoft 365 Copilot, make sure the following requirements are met:

- You must be a tenant administrator to install the integrated app from the [Microsoft 365 admin center](https://admin.microsoft.com/). To find out who is your tenant admin, see [How do I find my Microsoft 365 admin?](https://support.microsoft.com/en-us/office/how-do-i-find-my-microsoft-365-admin-59b8e361-dbb6-407f-8ac3-a30889e7b99b).
- You must be a Teams administrator to create a setup policy in the [Teams admin center](https://admin.teams.microsoft.com/dashboard).
- Admins must assign the Service in Microsoft 365 Copilot license to each user who can use the app. To learn how to assign licenses from the Microsoft 365 admin center, see [Assign licenses to users](/microsoft-365/admin/manage/assign-licenses-to-users?view=o365-worldwide&preserve-view=true).
- Make sure that you are on the latest version of Outlook, Teams, or the Outlook Web application.

### Deploy Service in Microsoft 365 Copilot

To deploy Service in Microsoft 365 Copilot in Customer Service, follow these steps:

1. **Deploy Service in Microsoft 365 Copilot**: Sign in to the [Microsoft 365 admin center](https://admin.microsoft.com/) and follow the steps in [Deploy your Office add-ins](/microsoft-365/admin/manage/office-addins#deploy-your-office-add-ins) to  deploy the **Service in Microsoft 365 Copilot** and **Service in Microsoft 365 Copilot for Microsoft Outlook** apps. The app is installed in Fixed mode by default. In Fixed mode, users receive the app automatically and can't remove it.<br>
Individual users can also install Service in Microsoft 365 Copilot from [Microsoft Marketplace](https://marketplace.microsoft.com/) and [Microsoft Teams](https://support.microsoft.com/en-us/office/add-an-app-to-microsoft-teams-b2217706-f7ed-4e64-8e96-c413afd02f77). <br>
   > [!NOTE]
   > - Service in Microsoft 365 Copilot accesses and manages the data in your CRM through the **Service in Microsoft 365 Copilot for Microsoft Outlook** add-in.
   > - It may take up to six hours for Service in Microsoft 365 Copilot to appear in service representatives' Outlook ribbon. They'll receive a pop-up notification when their administrator installs a new app.
1. **Install and pin the app in Microsoft Teams**: When you install Service in Microsoft 365 Copilot as an integrated app, the app is enabled in Teams but not installed automatically. You need to go to the Microsoft Teams admin center and create [setup policies](/microsoftteams/app-policies#app-setup-policies) to install and pin the app for your users. Pinning the app makes it easier for users to find and use it. To do this, follow these steps:
   - Sign in to the [Teams admin center](https://admin.teams.microsoft.com/dashboard).
   - Follow the steps in [pin apps](/microsoftteams/teams-app-setup-policies#pin-apps) to pin the **Service in Microsoft 365 Copilot** app and then [assign the policy to a user group](/microsoftteams/policy-assignment-overview) (security group, organizational unit, or distribution list).
   > [!NOTE]
   > - Service in Microsoft 365 Copilot app is supported in Teams only with the dark theme enabled.  
   > - When you assign a policy to a group, it should be the group that service representatives belong to. If your service representatives are spread across multiple groups, you need to create multiple group policy assignments.

## Related information

[Use Service Agent in Customer Service]
