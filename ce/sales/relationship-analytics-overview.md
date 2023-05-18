---
title: Relationship analytics and KPIs overview 
description: Relationship analytics uses the activity history of a seller with a contact or account and calculates KPIs based on their interactions. The KPIs are available at various levels such as, contact, account, opportunity, and lead.  
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/26/2023
ms.custom: bap-template
---

# Relationship analytics and KPIs overview

> [!IMPORTANT]
> This feature is intended to help sellers or sales managers enhance their team’s performance. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with sales persons may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their sales persons that their communications with end users may be monitored, recorded, or stored.

Relationship analytics uses the activity history of a seller with a contact or account and calculates KPIs based on their interactions. The KPIs are available at various levels such as, contact, account, opportunity, and lead. The graphical display of the KPIs help you quickly identify relationships that need to be nurtured and the KPIs to be improved for the same.  

Relationship analytics help sales professionals and managers answer questions such as:  

- Which opportunities should I spend my time on?  
- Do we have a good relationship with the customer?  
- How much time have we spent with our customer?  
- When was the last time we contacted them?  
- When is the next time we will contact them?  
- How many emails and meetings have we exchanged?  
- What is the customer's response rate?  
- How many activities were initiated by the customer?  
- How long does it take our team to respond?  

Depending on your license and configuration, you get the following insights:
 
- Basic relationship insights
- Enhanced relationship insights

## Basic relationship insights

Basic relationship insights are generated out-of-the-box by using emails and appointments sent and received from Dynamics 365. The seller-customer interaction history is used to calculate KPIs and understand who knows whom. For information on how to view the insights, [View analytics and KPIs for a record](relationship-analytics.md#view-analytics-and-kpis-for-a-record)

The following screenshot displays the widgets that are available out-of-the-box in the **Relationship Analytics** tab of a lead. Similar widgets are also available in Contact, Account, and Opportunity entities.

:::image type="content" source="media/relationship-analytics-tab.png" alt-text="Screenshot of the relationship analytics widgets available out-of-the-box." lightbox="media/relationship-analytics-tab.png":::

|Number|Widget  |Description  |Available for  |
|------|---------|---------|---------|
| 1 |Summary   | Shows the summary of metrics and KPIs obtained for the records from your interactions with customers through emails, meetings, and phone calls. For example, *You have initiated 3 meetings more compared to the customer.*  |Account, Contact, Lead, Opportunity    |
| 2 |Most contacted and Most contacted by   | Shows the top three active contacts for the deal from your and your customer's organizations, with details about the number of times they've interacted and the modes of interaction. The **Last updated date** shows the timestamp of the last KPI calculation.     | Account, Lead, and Opportunity  |
| 3 |Customer interactions   | Shows the number of interactions initiated by you versus your customer's contacts. The graph displays the total number of activities initiated by members of your team and by the customer's contacts. The activities are broken down by general type, such as email, meetings, and phone calls. | Account, Contact, Lead, Opportunity    |
| 4 |Email engagement   | Summarizes how your customer has interacted with the followed emails that your team has sent to them. Unfollowed emails are not included, so you must enable and use the email-engagement feature to see any information here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use email engagement to view message interactions](email-engagement.md).    |Account, Contact, Lead, Opportunity    |
| 5 |Email sent/received ratio   | Shows the ratio of the number of emails sent by you and received by the customer related to a record.      | Account, Contact, Lead, Opportunity    |
| 6 |Relationship activities   | Provides a detailed look at activities over 60 days, broken down by date and activity type, such as emails sent, emails received, meetings sent, meetings received, phone calls made, and phone calls received. Use this widget to view the seller-customer interactions over the last 60 days and gain insight into interaction frequency and period of non-interaction. You can use this insight to define healthy interaction frequency.    | Account, Contact, Lead, Opportunity    |

## Enhanced relationship insights

Enhanced relationship insights are available with the Sales Premium license and requires your administrator to enable and configure relationship intelligence. Your administrator can configure relationship intelligence to use the Exchange data as well. In this case, the insights will be generated based on emails and meetings information in Exchange and Dynamics 365.  More information: [Enable relationship intelligence](enable-ri.md)

For information on how to view the insights, see [View analytics and KPIs for a record](relationship-analytics.md#view-analytics-and-kpis-for-a-record).

The following screenshot displays the  enhanced  relationship insights that are available in the **Relationship Analytics** tab of an opportunity. Similar widgets are also available in Contact, Account, and Lead entities. For Opportunity records, the KPIs are compared with similar won deals. For more information, see [Compare the KPIs of an opportunity with similar opportunities](relationship-analytics.md#compare-the-kpis-of-an-opportunity-with-similar-opportunities).

:::image type="content" source="media/relationship-analytics-tab-advanced.png" alt-text="Screenshot of the enhanced relationship analytics widgets available with Sales Premium." lightbox="media/relationship-analytics-tab-advanced.png":::


|Number|Widget  |Description  |Available for  |
|------|---------|---------|---------|
| 1 |Summary   | Shows the summary of metrics and KPIs obtained for the records from your interactions with customers through emails, meetings, and phone calls. For example, *You have initiated 3 meetings more compared to the customer.*  |Account, Contact, Lead, Opportunity    |
| 2 |Relationship health   |  Shows your overall relationship health with the customer, and includes the recent trend for the deal. <br>- **Next interaction.** Shows the date and time for the next activity that's scheduled for the record. If you have access to that activity, you'll also see its name or subject. The next and last interactions are only shown for opportunity and lead entities.<br> - **Last interaction.** Shows the date and time for the last activity that you completed for the record. If you have access to that activity, you'll also see its name or subject. The next and last interactions are only shown for opportunity and lead entities.     | Contact, Lead, Opportunity  |
| 3 |Most contacted and Most contacted by   | Shows the top three most active contacts for the deal from you and your customer's organizations, with details about the last time these contacts interacted.      | Account, Lead, and Opportunity  |
| 4 |Customer interactions   | Shows the number of interactions initiated by you versus your customer's contacts. The graph displays the total number of activities initiated by members of your team and by the customer's contacts. The activities are broken down by general type, such as email, meetings, and phone calls. | Account, Contact, Lead, Opportunity    |
| 5 |Hourly investment   | Use this widget to compare the time spent by sellers versus the customer's contacts on a specific record.  For more information on how this value is calculated, see [Relationship analytics KPI calculations](relationship-analytics-kpi-calculations.md)     | Account, Lead, and Opportunity  |
| 6 |Email engagement   | Summarizes how your customer has interacted with the followed emails that your team has sent to them. Unfollowed emails are not included, so you must enable and use the email-engagement feature to see any information here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use email engagement to view message interactions](email-engagement.md).    |Account, Contact, Lead, Opportunity    |
| 7 |Response time   |Shows the average amount of time taken by your sellers to respond to customer emails as compared to the time taken by your customers to respond.  [Connect to Exchange Online](/power-platform/admin/connect-exchange-online) to view data in this widget.    | Account, Contact  |
| 8 |Email sent/received ratio   | Shows the ratio of the number of emails sent by you and received by the customer related to a record.      | Account, Contact, Lead, Opportunity    |
| 9 |Relationship activities   | Provides a detailed look at activities over 60 days, broken down by date and activity type, such as emails sent, emails received, meetings sent, meetings received, phone calls made, and phone calls received. Use this widget to view the seller-customer interactions over the last 60 days and gain insight into interaction frequency and period of non-interaction. You can use this insight to define healthy interaction frequency.    | Account, Contact, Lead, Opportunity    |
| 10 |Similar won deals (**not shown in the screenshot**)  | Shows the list of similar opportunities that have been closed as won. The columns display activities count, time spent, response time, and the response ratio for each opportunity. You can select and open an opportunity to view what has worked better in a deal that was closed as won, and implement these observations in the current deal to help close it as well. The list is refreshed every seven days. To know how the similar won deals are identified, see [How are similar won deals identified?](faqs-sales-insights.md#similar-won-deals-fields)      |  Opportunity  |

