---
title: "Install the Voice of the Customer solution | MicrosoftDocs"
description: "Instructions to install the Voice of the Customer solution."
keywords: install voice of the customer
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 9191a75b-430f-4052-9de3-486197a5f0e4
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.reviewer: 
topic-status: Drafting
ms.custom:
  - dyn365-VoC
---

# Install or upgrade the Voice of the Customer solution

> [!IMPORTANT]
> Voice of the Customer (VoC) is being deprecated and replaced with Microsoft Forms Pro. [Learn more](https://go.microsoft.com/fwlink/p/?linkid=2097704)

This section provides you the steps to install the Voice of the Customer for Dynamics 365 solutions. If you're an administrator, you can find the version by going to **Settings** &gt; **Solutions**.

> [!NOTE] 
> Surveys aren't supported on legacy forms.

## Install or upgrade the Voice of the Customer solution, version 9.0 and later

 The Voice of the Customer for Dynamics 365 solution can be installed from [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)]. It is compatible with Dynamics 365 version 8.2 and later.

> [!NOTE]
> You must be a tenant administrator to install the solution.

1. Sign in to your Dynamics 365 solution as administrator.

2. Go to the [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)], and then select the **Applications** tab.

3. Select the application row titled **Voice Of The Customer**, and then select **Manage**.

4. From the **Dynamics 365 Instance** drop-down list, select the instance where you want to install the solution.

   > [!NOTE]
   > The list of instances only displays the organizations with Dynamics 365 version 8.2.

5. Accept the license terms.

6. Select **Install**.

When you install Voice of the Customer, a VOC Push Service user is created automatically. This user is created to allow Voice of the Customer Azure service to authenticate with Dynamics 365 for Customer Engagement using Server-to-Server (S2S) authentication, and is primarily used for pushing survey responses. The VOC Push Service user is an application user and does not consume any license. The user is assigned Survey Administrator role. More information on S2S authentication: [Server-to-Server (S2S) authentication](https://msdn.microsoft.com/library/mt790168.aspx).

> [!NOTE]
> The VOC Push Service user runs only with minimum required privileges to communicate to Voice of the Customer Azure service, and if your organization deploys a custom plugin that runs on the Survey Response entity, you are advised to do either of following:
> - Run the Custom Plugin in System User Context.
> - Create a custom role with privileges required by custom plugin operations and assign the security role to Voice of the Customer application user.


### Track the installation status 

1. Go to the [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)], and then select the **Instances** tab.
2. Select the instance name, and then select **Solutions**.
   The status is displayed in the **Status** column.


> [!NOTE]
> To optimize performance, we recommend following limits for Voice of the Customer for Dynamics 365:
> -   Maximum number of surveys you can publish: **200**
> -   Maximum number of questions on a survey: **250**. If you've enabled feedback for a survey, the maximum is 40 questions.
> -   Maximum number of pages per survey: **25**
> -   Maximum number of sections per page: **10**
> -   Maximum number of email invitations that you can send that include piped data in a 24-hour period: **50,000**. If you create more email invitations than the specified limit, an error message is displayed.
> 
> If you want to install Voice of the Customer solution version earlier than 9.0, see [here](voc-faq.md#how-to-install-voice-of-the-customer-solution-earlier-than-90).

## Voice of the Customer app

The Voice of the Customer app provides a new experience in survey designing as well as theme designing. The new survey designer provides a simple and intuitive experience for survey designers to add, remove, and modify survey pages, sections, questions, and answers.

When you install Voice of the Customer version 9.0.1162 and higher, the Voice of the Customer app, built on the Unified Interface framework, is created out-of-the-box.

### Open Voice of the Customer app

1. Sign in to the Voice of the Customer legacy web client.

2. Open the URL `<organization URL>/apps`.

3. Select the Voice of the Customer app.

> [!NOTE]
> - To use the Voice of the Customer app, a user must be assigned the **Voice of the Customer app access role** security role. If this role is not assigned, users will see the web client behavior in Voice of the Customer app. More information on how to assign a security role to a user: [Assign a security role to a user](https://docs.microsoft.com/dynamics365/customer-engagement/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user)
> - When you assign the **Voice of the Customer app access role** security role to a user, the user will see duplicate forms for a few entities (survey, theme, and image) in web client. These forms are built for the Unified Client interface and must be used from the Voice of the Customer app only.

### See also
[Plan a survey](plan-survey.md)    
[Design a basic survey](design-basic-survey.md)   
[Design an advanced survey](design-advanced-survey.md)   
[Distribute a survey](distribute-survey.md)   
[Analyze survey data](analyze-survey-data.md)   
