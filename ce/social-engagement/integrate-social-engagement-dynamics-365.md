---
title: "Social Engagement integration with Dynamics 365 | Microsoft Docs"
description: "Learn about the available integrations with Dynamics 365 and additional services."
keywords: ""
ms.date: 03/23/2018
ms.service: mse
ms.topic: article
applies_to:
  - "Social Engagement"
ms.assetid: f780a931-3fcc-468a-9849-a22aab60984b
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# Integrate Microsoft Social Engagement with Dynamics 365

In [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)], you can get powerful social insights by connecting [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] collects data from social media websites and presents it to you in charts and graphs that you can use to spot emerging trends in people’s comments, whether they’re positive, negative, or neutral. You can drill down into the data and see who is mentioning you, where they posted the comment, and exactly what they said. Armed with these insights, you can pinpoint what you’re doing right, and address potential issues before bigger problems arise.

With [!INCLUDE[pn_social_insights](../includes/pn-social-insights.md)], you bring social media data directly into Dynamics 365 dashboards and entity forms. As an administrator, you configure the connection to Microsoft Social Engagement and add the [!INCLUDE[pn_social_insights](../includes/pn-social-insights.md)] controls to the entity forms and system dashboards. You use the [!INCLUDE[pn_social_insights](../includes/pn-social-insights.md)] controls to specify what social data you want to see and in what form you want this data to be presented to you. When you set up the [!INCLUDE[pn_social_insights](../includes/pn-social-insights.md)] controls, you choose a search topic or search topic category and visuals. After you choose the search topic or category, you pick the visuals. It can be a graph or chart, or some other visual representation of data. You can find a lot of interesting, useful, and easy to follow information.

[comment]: <> (For Apr30: Create list of all widgets and replace ebook with web page.)

When you look for [detailed analysis of your data](analyze-social-data-using-widgets.md), usually, you work directly in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
  
## Connect Dynamics 365 (online) to Microsoft Social Engagement for Social Insights

To configure the connection, you need to have a subscription to Microsoft Social Engagement, be an authorized Microsoft Social Engagement user and have a Microsoft Social Engagement instance provisioned for this Dynamics 365 instance.

### Prerequisites

- You need to have a System Administrator security role or equivalent permissions in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)].

- You must ensure that your Dynamics 365 domain is [added to the list of allowed domains](connect-other-domains.md) in Microsoft Social Engagement. 

### Connect Dynamics 365 (online) to Social Engagement

1. In Dynamics 365, select **Settings** > **Administration** > **Microsoft Social Engagement Configuration**.

2. Click **Continue** to accept the legal disclaimer.

3. On the **Microsoft Social Engagement Configuration** page, in the **Select the Microsoft Social Engagement solution to connect to** dropdown box, choose the Microsoft Social Engagement instance to which you want to connect. Choose the **Select** button next to the dropdown box. The **Select** button becomes grayed out to indicate that the selection is confirmed.
  

> [!WARNING]
> If you want to switch to a different Microsoft Social Engagement instance, you are asked to confirm it. Changing the Microsoft Social Engagement instance, may cause any existing Social Insights controls on forms and dashboards to display error messages, because the new instance may not have matching data. All existing Social Insights controls may need to be reconfigured. Also, the existing Social Insights data in Dynamics 365 may need to be reset to remove references to the old instance data.

[comment]: <> (Add link to reset section)

## Connect Dynamics 365 on-premises to Microsoft Social Engagement for Social Insights

### Prerequisites

- You need to have a System Administrator security role or equivalent permissions in [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)].

- You must ensure that your Dynamics 365 domain is [added to the list of allowed domains](connect-other-domains.md) in Microsoft Social Engagement.

[comment]: <> (IFD required for on-prem?)


### Connect Dynamics 365 on-premises to Social Engagement

1. In Dynamics 365, select **Settings** > **Administration** > **Microsoft Social Engagement Configuration**.

2. Click **Continue** to accept the legal disclaimer.

3. Follow the directions on the Microsoft Social Engagement Configuration page.
  
## Set up search topics from within Dynamics 365  
  
> [!NOTE]
>  Search topics are usually created by Administrators or Power Analysts directly in the settings of [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)]. However, to get up and running quickly, users with Administrator or Power Analyst user roles in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] can set up searches from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
 To have the full set of options for creating a search topic available, it’s a good idea to work directly in [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)].  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [CRM Help & Training: Set up your own searches for Social Engagement](http://go.microsoft.com/fwlink/p/?LinkID=391710), [Marketing Help & Training: Maintain your Social Engagement search terms](http://go.microsoft.com/fwlink/p/?LinkId=526315)  
  
## Add Social Engagement visuals to Dynamics 365  
 [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] users can add [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] charts and visuals to dashboards, or they can add them to account, contact, or competitor forms. You can also add [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] charts and visuals to other entity type forms.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [CRM Help & Training: Add Social Engagement visuals to a dashboard or account](http://go.microsoft.com/fwlink/p/?LinkID=391707)  
  
 Download the eBook: [Microsoft Social Engagement for CRM](http://go.microsoft.com/fwlink/p/?LinkID=393642)  

## Reset Social Insights

This action deletes all existing data in Dynamics 365 for the search topics, search topic categories and visuals for Social Insights.

1. Click **Settings** > **Administration** > **Microsoft Social Engagement Configuration**.

2. On the **Microsoft Social Engagement Configuration** page, choose **Reset Social Insights**. The **Reset Social Insights Confirmation** message box appears, choose **Confirm**, if you want to proceed, otherwise choose **Cancel**.

## Troubleshoot sign-in problems  
 Having trouble signing in to [!INCLUDE[pn_netbreeze_short](../includes/pn-social-engagement-short.md)] or another [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] service? Read [CRM Help & Training: Troubleshoot sign-in problems](http://go.microsoft.com/fwlink/p/?LinkId=516923) for available resolutions.  
  
### See Also  
 [Get started with Social Engagement](get-started.md)   
 [Administer Microsoft Social Engagement](administer-microsoft-social-engagement.md)   
 [Assign permissions and user roles](assign-user-roles.md)   
 [ebook: Microsoft Social Engagement for CRM](http://go.microsoft.com/fwlink/p/?LinkID=393642)
 
