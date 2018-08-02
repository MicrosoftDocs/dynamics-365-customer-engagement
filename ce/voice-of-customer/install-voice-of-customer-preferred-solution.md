---
title: "Install the Voice of the Customer for Microsoft Dynamics 365 preferred solution | MicrosoftDocs"
description: ""
ms.assetid: 6ede301c-1061-4f13-887f-89dbde408c01
ms.custom:
  - dyn365-VoC
ms.date: 07/26/2017
ms.service: dynamics-365-customerservice
ms.topic: "article"
applies_to: "Dynamics 365 (online)"
redirect_url: /dynamics365/customer-engagement/voice-of-customer/install-solution
author: sbmjais
ms.author: shjais
manager: sakudes
---
# Install the Voice of the Customer solution
This section provides you the steps to install the [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] solutions earlier than 9.0 and latest version.

## Install the Voice of the Customer solution earlier than 9.0

[!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] is a preferred solution that you install from [!INCLUDE[pn_MS_Office_365](../includes/pn-ms-office-365.md)]. To learn how to install preferred solutions, see [TechNet: Install a preferred solution](https://technet.microsoft.com/en-us/library/dn878909).  
  
After you've installed the [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] preferred solution, you need to accept the terms and conditions to configure it in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. 
 
 
1.  Go to **Settings > Customizations**.  
  
2.  Click **Solutions**.  
  
3.  In the list of available solutions, select **[!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)]**.  
  
4.  In the **[!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] Configuration** screen, select **I agree to the terms  and conditions** and click **Enable [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)]**.  
  
When  the configuration completes, you can start using [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] solution.  
  
## Install the Voice of the Customer solution 9.0 and later

The new version of the [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] solution can be installed from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Administration Center. It is compatible with [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] version 8.2 onwards.

> [!Note]
> You must be a tenant administrator to install the solution.

1. Go to the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Administration Center and click the **Applications** tab.
2. Select the application row titled **Voice Of The Customer** and click **Manage**. The Install page is displayed.
3. From the **[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Instance** drop-down list, select an instance where you want to install the solution.
  
  > [!Note]
  > The **[!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Instance** drop-down list will display only the organizations with version 8.2 and above.

4. Accept the license terms.
5. Click **Install**.

You can track the installation status from the solutions page of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Administration Center.

1. Go to the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] Administration Center and click the **Instances** tab.
2. Select the instance name and click **Solutions**.
3. The status is displayed in the **Status** column.

## Limitations of the Voice of the Customer solution

[!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] has the following limitations designed to optimize performance:  
  
- Maximum # of surveys you can publish: **200**  
- Maximum # of questions on a survey: **250**. If you've enabled feedback for a survey, you can include a maximum of 40 questions.  
- Maximum # of pages per survey: **25**  
- Maximum # of survey responses that [!INCLUDE[pn-voice-of-the-customer](../includes/pn-voice-of-the-customer.md)] will store: **1,000,000** 
- Note that surveys aren't supported on legacy forms. 
   
The following limitations also apply if you're using a version earlier than 9.0.781.3. If you're not sure which version you're using, talk to your administrator. If you're an administrator, you can find the version by going to **Settings > Solutions**.

-   Maximum # of email invitations that you can send that include piped data in a 24-hour period: **10,000**. Any emails that exceed that amount will remain pending during that time and will automatically start sending when the time limit is over.  
-   Maximum # of survey responses you can pull per day: **2400**.

> [!IMPORTANT]
>  The [!INCLUDE[pn-voice-of-the-customer-full](../includes/pn-voice-of-the-customer-full.md)] preferred solution connects to an external service that isn't completely within the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] compliance boundary.

## Privacy notice  
 [!INCLUDE[cc_privacy_crm_voice_of_customer](../includes/cc-privacy-crm-voice-of-customer.md)]  
  
