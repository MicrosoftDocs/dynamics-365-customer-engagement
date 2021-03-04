---
title: "Best practices for KPIs in Dynamics 365 - Gamification | Microsoft Docs"
description: "Learn about the best practices for KPIs to run smooth games in Gamification while providing visibility and transparency to players and fans."
ms.custom: 
  - dyn365-gamification
ms.date: 05/31/2017
ms.service: dynamics-365-sales
ms.topic: article
ms.assetid: fb73fc31-e6e8-43ca-b0cd-9e22bab4d1f4
author: m-hartmann
ms.author: mhart
manager: sakudes
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Gamification
---
# Best practices for new and existing KPIs in Gamification

[!INCLUDE[pn_gamification](../includes/pn-gamification.md)] includes several default KPIs when the solution is installed. For more information about installing [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)] in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], see [Install and configure the Gamification solution](manage-gamification-in-dynamics-365-online.md).

You can edit or remove default KPIs according to your organization's requirements. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Configure KPIs for Gamification in Dynamics 365 apps](configure-kpis.md)

## Useful KPI scenarios

Motivate your reps to generate new leads and opportunities, get the most out of the teams that work with customers, or help them troubleshoot issues.

There are various way to create useful KPIs based on the data of a [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instance. Consider the examples below for inspiration and adapt them to your business and game requirements.

Let us know what KPIs you find work well, or not so well, on the [Dynamics Community Forum](https://go.microsoft.com/fwlink/p/?LinkId=825550).


|       KPI name        |                                            KPI configuration                                             |                          Business scenario                          |
|-----------------------|----------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------|
|     Appointments      |                                 5 points for every appointment created.                                  |             -   Lead generation<br />-   Outside sales              |
|      Calls made       |                         2 points for every successful call with a prospect/lead.                         | -   Lead generation<br />-   Inside sales<br />-   Customer service |
|    Cases resolved     |      20 points for every case resolved in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].       |                        -   Customer service                         |
|      Emails sent      |                                 1 point for every email sent to a lead.                                  | -   Lead generation<br />-   Inside sales<br />-   Customer service |
|     Leads created     | 10 points for every new lead record created in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].  |              -   Lead generation<br />-   Inside sales              |
| Opportunities created | 20 points for every new opportunity created  in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. |             -   Lead generation<br />-   Outside sales              |
|    Pipeline added     |                  1 point for every $1,000 potential revenue added to a sales pipeline.                   |               -   Inside sales<br />-   Outside sales               |
|      Revenue won      |                               3 points for every $1,000 confirmed revenue.                               |               -   Inside sales<br />-   Outside sales               |
|    Tasks completed    |      10 points for every completed task in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].      |                        -   Customer service                         |

> [!TIP]
> - Have a  look at a comparable periods (previous month/ quarter/ same period in prior year) to estimate the average performance on KPIs and adjust points and scores to your business requirements.
> - Although it isn't reflected in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], any KPI (especially revenue KPIs) can be set as a quota KPI in [!INCLUDE[pn_gamification_shortest](../includes/pn-gamification-shortest.md)]. It could be an actual performance against quota, or reps could be providing their own quotas as forecasts, in which case the true KPI being measured would be forecast accuracy.
> - Many KPIs have been completely customized, based on higher-level activity represented in custom entities or standard entities that have been customized to meet the requirements of a specific organization.
> - You can include fun KPIs as well. Sometimes important activities aren't tracked in [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. You can score these KPIs as bonus points by using [!INCLUDE[pn_microsoft_excel](../includes/pn-microsoft-excel.md)] in combination with [!INCLUDE[pn_Excel_short](../includes/pn-excel-short.md)] point scoring capabilities. For example, you might reward your employees for cycling to work instead of driving. [!INCLUDE[proc_more_information](../includes/proc-more-information-md.md)] [Update game scores by using Excel point scoring capabilities in Gamification](update-scores-using-excel-point-scoring.md)

### See also

 [Overview for commissioners and game managers in Gamification](for-commissioners-game-managers.md)  
 [Configure KPIs for Gamification in Dynamics 365 apps](configure-kpis.md)  
 [Update game scores by using Excel point scoring capabilities in Gamification](update-scores-using-excel-point-scoring.md)  
 [Set up and run games in Gamification](run-games.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]