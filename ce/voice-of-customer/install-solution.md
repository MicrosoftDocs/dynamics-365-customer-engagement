---
title: "Install the Voice of the Customer solution | MicrosoftDocs"
description: "Instructions to install the Voice of the Customer solution."
keywords: "install voice of the customer"
ms.date: 11/13/2017
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

This section provides you the steps to install the Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] solutions earlier than 9.0, and also the latest version. If you're an administrator, you can find the version by going to **Settings** &gt; **Solutions**.

> [!NOTE] 
> Surveys aren't supported on legacy forms.

## Install the Voice of the Customer solution, versions earlier than 9.0

Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] is a preferred solution that you install from [!INCLUDE[pn-ms-office](../includes/pn-ms-office.md)] 365. More information about how to install preferred solutions: [Install a preferred solution](https://technet.microsoft.com/en-us/library/dn878909)  

> [!NOTE] 
> If you're using Voice of the Customer version 9.0.781.3 or earlier, maximum number of survey responses you can pull per day is **2,400**.

### Enable and configure Voice of the Customer

After you've installed the Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] preferred solution, you need to enable and configure it in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].

1.  Go to **Settings** &gt; **Customizations**.

2.  Select **Solutions**.

3.  In the list of available solutions, select **Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]**.
 
4.  In the **Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] Configuration** screen, select **I agree to the terms and conditions** and select **Enable Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]**.

When the configuration is complete, you can start using the Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] solution.

> [!IMPORTANT]
> The Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] preferred solution connects to an external service that isn't completely within the [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] compliance boundary.

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



### See also
[Plan a survey](plan-survey.md)    
[Design a basic survey](design-basic-survey.md)   
[Design an advanced survey](design-advanced-survey.md)   
[Distribute a survey](distribute-survey.md)   
[Analyze survey data](analyze-survey-data.md)   
