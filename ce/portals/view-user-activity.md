---
title: "View user activity on a portal for Dynamics 365 | MicrosoftDocs"
description: "Instructions to view activity of a user on a portal."
ms.custom: ""
ms.date: 09/28/2017
ms.service: crm-online
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: article
ms.assetid: 560B551E-ED9A-4772-9BA7-667D93C18498
ms.reviewer: ""
redirect_url: /dynamics365/customer-engagement/portals/administer-manage-portal-dynamics-365
author: sbmjais
ms.author: shjais
manager: sakudes
---

# View activity of a user on a portal
Dynamics 365 for Customer Insights (DCI) is a cloud-based SaaS service that enables organizations of all sizes to bring together data from multiple sources and generate knowledge and insights to build a holistic 360° view of their customers.

You can enable a portal to send data from a user’s activity to your DCI instance. This will be helpful in knowing the user’s journey on a portal before and after creating a case. This also helps you to understand the real issue, avoid asking the same information again from the user, and enable you to respond with the relevant information.

Let’s take the following scenario:

Jay is the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] administrator and he is interested in knowing the activity of the portal users before the case is submitted. Jay purchases a DCI instance from Azure portal by using his own subscription plan. Jay then navigates to the Portal Admin Center and configures his portal to use the DCI instance he purchased.

[!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] portals needs the latest shared access key to send the interactions to DCI. Jay navigates to the Portal Admin Center and he can see the currently configured DCI instance. Jay can change the DCI instance or update the shared access key for the currently configured DCI instance.

To view activity of a user on a portal:
1.	Go to the [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] Administration Center page and select the **Applications** tab.
2.	Select the name of the portal you want to view user’s activity, and then select **Manage**.
3.	Select **Portal Analytics**. The Tracking Portal Interaction page is displayed.
4.	Select **Configure Portal Interaction Tracking**. The Configure Portal Interaction Tracking window is displayed.
5.	Enter the following values as per your Dynamics 365 Customer Insights instance:
    - [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] for the Customer Insights hub URI 
    - Policy name with Manage, Read, and Write permissions 
    - Shared Key
6.	Read the preview agreement and select the **I have read and understood the terms and conditions** check box.
7.	Select **Configure**. A progress window is displayed.
8.	Select **Close** in the confirmation window.

After DCI is configured on a portal, the following actions become available:
- **Update D365 Customer Insights configuration**: Allows you to update the shared key related to your policy. The hub URI is read-only.
- **Delete D365 Customer Insights integration**: Allows you to delete the connection configuration between your DCI and your portal.

## Configure DCI
To persist interactions in a customer’s DCI, the portal needs to create the interaction-related configuration in DCI. These interactions need to be tied against a DCI Profile.

> [!Note]
> [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] supports multiple portals, and they can use the same DCI instance.

A portal user can view knowledge articles, blogs, forum threads, and portal search exposed on the portal.

To allow a seamless experience, the following interactions are captured in DCI:


|Interaction name   |Display Name   |Fields   |Description   |Parameters captured|
|---|---|---|---|---|
|portal\_viewknowledgearticle |Knowledge article   |portal\_interactionid, portal\_knowledgearticleid, portal\_knowledgetitle, portal\_contactid, portal\_timestamp,  portal\_portalid |Tracks portal users viewing a knowledge article   |Knowledge article id, language, session id, portal id |
|portal\_viewblogpost   |Blog post   |portal\_interactionid,portal\_blogpostid, portal\_blogtitle, portal\_contactid, portal\_timestamp, portal\_portalid   |Tracks portal users viewing a blog post   |Blog post id, session id, portal id |
|portal\_viewforumthread   |Forum thread   |portal\_interactionid,portal\_forumthreadid, portal\_forumthreadtitle, portal\_contactid, portal\_timestamp, portal\_portalid   |Tracks portal users viewing a forum thread   |Forum Thread id, session id, portal id |
|portal\_search   |Portal Search   |portal\_interactionid, portal\_contactid, portal\_searchstring, portal\_timestamp, portal\_portalid   |Tracks portal users’ searches.   | |
||

As a Portal Administrator, you can configure which interaction gets ingested into DCI through portals as per the customer’s requirement. To prevent a specific interaction being captured by a portal, you can delete the interaction type from DCI.

A portal persists all its data in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. All the data required to render content on the portal comes from [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]. Data in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] will be used to model profiles and the portal interactions will be tied to it. Portals will not create custom profiles. As a Portal Administrator, you must manually connect this [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)] organization to DCI and create profiles. You need to configure the Contact entity as a profile and then link the Contact to the portal interactions, using the `crmrecordid` which is persisted as `portal_contactid` in the portal interactions. After creating profiles, the administrator must manually link the profiles to the portal interaction type. This will allow the administrator to create charts and profile views.

[!include[More information](../includes/proc-more-information.md)] [Set up Customer Insights](https://docs.microsoft.com/dynamics365/customer-insights/deploy/stepbystepconfiguration)

## Visualize the customer journey
Visualizing a customer journey allows you to view the user’s activity in chart format. This tells you what activities a user has already performed before submitting the case, so you can provide relevant information.

Let’s take the following scenario:

Sharron is the CSR executive working on the cases in Contoso, Ltd. Sharron frequently helps her customers resolve customer issues by sharing the link to knowledge articles in the `http://support.contoso.com` self-service portal. At times, Sharron shared the same articles her customers had already read, which resulted in poor customer satisfaction. 

The Customer Journey chart is embedded on the Case form, which displays the portal user’s activity moments before the case was created. This helps Sharron share relevant information that helps resolve the issue in a more effective way.

[!include[More information](../includes/proc-more-information.md)]  [Set up Customer Insights](https://docs.microsoft.com/dynamics365/customer-insights/deploy/stepbystepconfiguration)