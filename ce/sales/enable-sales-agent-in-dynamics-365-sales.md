---
title: Enable Sales Agent in Microsoft 365 Copilot for Dynamics 365 Sales (preview)
description: Learn how to enable the Sales Agent in Dynamics 365 Sales so sales representatives can use Copilot to get responses based on relevant sales information.
ms.date: 03/31/2026
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.update-cycle: 180-days
---

# Enable Sales Agent in Microsoft 365 Copilot for Dynamics 365 Sales (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Sales Agent in Microsoft 365 Copilot is an AI-powered assistant that helps sales representatives by providing insights and responses based on relevant sales information from Dynamics 365 Sales. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

## Enable Sales Agent

To enable Sales Agent in Dynamics 365 Sales, there are two key procedures that are required:

1. The Microsoft 365 administrator must enable and install the Sales in Microsoft 365 Copilot app that contains Sales Agent. Do the steps in [Enable and install Sales in Microsoft 365 Copilot app](#enable-and-install-sales-in-microsoft-365-copilot-app).
1. The Dynamics 365 organization administrator must add the Microsoft 365 Copilot application to the Dynamics environment. Do the steps in [Add Microsoft 365 Copilot for app users in model-driven apps (preview)](/power-apps/maker/model-driven-apps/add-microsoft-365-copilot).

After you enable Sales Agent, sales representatives in your organization can use the agent in Microsoft 365 Copilot chat and in the Copilot Sales workspace app.

## Enable and install Sales in Microsoft 365 Copilot app

Sales in Microsoft 365 Copilot is an app that integrates with Dynamics 365 Sales and uses AI to help sales representatives work more efficiently.

You can install Sales in Microsoft 365 Copilot from [Microsoft Marketplace](https://marketplace.microsoft.com/).

### Prerequisites

Before you can install Sales in Microsoft 365 Copilot, make sure the following requirements are met:

- You must be a Microsoft 365 administrator to install the Sales in Microsoft 365 Copilot integrated app from the [Microsoft 365 admin center](https://admin.microsoft.com/). To find out who is your tenant admin, see [How do I find my Microsoft 365 admin?](https://support.microsoft.com/en-us/office/how-do-i-find-my-microsoft-365-admin-59b8e361-dbb6-407f-8ac3-a30889e7b99b).
- You must be a Teams administrator to create a setup policy in the [Teams admin center](https://admin.teams.microsoft.com/dashboard).
- Admins must assign the Microsoft 365 Copilot license to each user who can use the app. Specific licensing requirements apply when you use Sales in Microsoft Copilot in Dynamics 365 Sales. Learn more in the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).
- Make sure that your representatives are on the latest version of Outlook, Teams, or the Outlook Web application.

### Deploy Sales in Microsoft 365 Copilot

When you deploy the Sales in Microsoft 365 Copilot app, keep in mind the following:

- Sales in Microsoft 365 Copilot accesses and manages the data in your CRM through the **Sales in Microsoft 365 Copilot for Microsoft Outlook** add-in.
- It might take up to six hours for Sales in Microsoft 365 Copilot to appear in sales representatives' Outlook ribbon. They receive a pop-up notification when their administrator installs a new app.
- Sales in Microsoft 365 Copilot is supported in Teams only with the dark theme enabled.  
- When you assign a policy to a group, it should be the group that sales representatives belong to. If your representatives are spread across multiple groups, you need to create multiple group policy assignments.

To deploy Sales in Microsoft 365 Copilot in Dynamics 365 Sales, follow these steps:

1. **Add the Sales in Microsoft Copilot and Sales in Microsoft 365 Copilot for Microsoft Outlook apps**: Sign in to the [Microsoft 365 admin center](https://admin.microsoft.com/) and follow the steps in [Deploy your Office add-ins](/microsoft-365/admin/manage/office-addins#deploy-your-office-add-ins) to deploy the **Sales in Microsoft 365 Copilot** and **Sales in Microsoft 365 Copilot for Microsoft Outlook** apps. The apps are installed in Fixed mode by default. In Fixed mode, users receive the app automatically and can't remove it.
   Individual users can also install Sales in Microsoft 365 Copilot from [Microsoft Marketplace](https://marketplace.microsoft.com/) or [Microsoft Teams](https://support.microsoft.com/en-us/office/add-an-app-to-microsoft-teams-b2217706-f7ed-4e64-8e96-c413afd02f77).
   
1. **Install and pin the app in Microsoft Teams**: When you install Sales in Microsoft 365 Copilot as an integrated app, the app is enabled in Teams but not installed automatically. You need to go to the Microsoft Teams admin center and create [setup policies](/microsoftteams/app-policies#app-setup-policies) to install and pin the app for your users. Pinning the app makes it easier for users to find and use it. To do this, follow these steps:
   - Sign in to the [Teams admin center](https://admin.teams.microsoft.com/dashboard).
   - Follow the steps in [pin apps](/microsoftteams/teams-app-setup-policies#pin-apps) to pin the **Sales in Microsoft 365 Copilot** app, and then [assign the policy to a user group](/microsoftteams/policy-assignment-overview) (security group, organizational unit, or distribution list).

 
## Related information

[Use Sales Agent in Dynamics 365 Sales](../use/use-sales-agent.md) 
