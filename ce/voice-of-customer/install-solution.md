---
title: "Install the Voice of the Customer solution | MicrosoftDocs"
description: "Instructions to install the Voice of the Customer solution."
keywords: "install voice of the customer"
ms.date: 05/15/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 9191a75b-430f-4052-9de3-486197a5f0e4
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Install the Voice of the Customer solution

This section provides you the steps to install the Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] solutions. If you're an administrator, you can find the version by going to **Settings** &gt; **Solutions**.

> [!NOTE] 
> Surveys aren't supported on legacy forms.

## Install the Voice of the Customer solution, version 9.0 and later

 The Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] solution can be installed from [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)]. It is compatible with [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] version 8.2 and later.

> [!NOTE]
> You must be a tenant administrator to install the solution.

1.  Sign in to your [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] solution as administrator.

2.  Go to the [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)], and then select the **Applications** tab.

3.  Select the application row titled **Voice Of The Customer**, and then select **Manage**.

4.  From the **[!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] Instance** drop-down list, select the instance where you want to install the solution.

	> [!NOTE]
	> The list of instances only displays the organizations with [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] version 8.2.

5.  Accept the license terms.

6.  Select **Install**.

When you install Voice of the Customer, a VOC Push Service user is created automatically. This user is created to allow Voice of the Customer Azure service to authenticate with Dynamics 365 using Server-to-Server (S2S) authentication. The VOC Push Service user is an application user and does not consume any license. The user is assigned Survey Administrator role. More information on S2S authentication: [Server-to-Server (S2S) authentication](https://msdn.microsoft.com/en-us/library/mt790168.aspx).

> [!NOTE]
> The VOC Push Service user runs only with minimum required privileges to communicate to Voice of the Customer Azure service, and if your organization deploys a custom plugin that runs on the Survey Response entity, you are advised to do either of following:
> - Run the Custom Plugin in System User Context.
> - Create a custom role with privileges required by custom plugin operations and assign the security role to Voice of the Customer application user.


### Track the installation status 

1.  Go to the [!INCLUDE[pn-crm-online-admin-center](../includes/pn-crm-online-admin-center.md)], and then select the **Instances** tab.
2.  Select the instance name, and then select **Solutions**.
    The status is displayed in the **Status** column.


> [!NOTE] 
> To optimize performance, we recommend following limits for Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]:
> -   Maximum number of surveys you can publish: **200**
> -   Maximum number of questions on a survey: **250**. If you've enabled feedback for a survey, the maximum is 40 questions.
> -   Maximum number of pages per survey: **25**
> -   Maximum number of sections per page: **10**
> -   Maximum number of email invitations that you can send that include piped data in a 24-hour period: **50,000**. If you create more email invitations than the specified limit, an error message is displayed.

> If you want to install Voice of the Customer solution version earlier than 9.0, see [here](voc-faq.md#how-to-install-voice-of-the-customer-solution-earlier-than-90).

## Voice of the Customer app

The Voice of the Customer app provides a new survey- and theme-designing experience. The new survey designer provides a simple and intuitive experience for survey designers to add, remove, and modify survey pages, sections, questions, and answers. The existing surveys and themes also are upgraded when you upgrade to the latest version of Voice of the Customer.

When you install Voice of the Customer version <<Version_Number>> and higher, the Voice of the Customer app, built on the Unified Interface framework, is created by default.

### Open Voice of the Customer app

1. Sign in to Dynamics 365.

2. Open the URL `<organization URL>/apps`.

3. Select the Voice of the Customer app.

### See also
[Plan a survey](plan-survey.md)    
[Design a basic survey](design-basic-survey.md)   
[Design an advanced survey](design-advanced-survey.md)   
[Distribute a survey](distribute-survey.md)   
[Analyze survey data](analyze-survey-data.md)   
