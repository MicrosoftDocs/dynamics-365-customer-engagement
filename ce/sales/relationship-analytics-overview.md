---
title: Relationship analytics and KPIs overview  #Required; page title displayed in search results. Don't enclose in quotation marks.
description: Understand the basic and advanced relationship analytics and KPIs available.  
ms.date: 06/13/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 01/30/2023
ms.custom: bap-template
---

## Relationship analytics and KPIs overview

Dynamics 365 Sales offers relationship analytics and KPIs at two-levels:

- Basic relationship insights
- Advanced relationship insights


## Basic relationship insights

Basic relationship insights are generated out-of-the-box by using emails and appointments sent and received from Dynamics 365. Seller-customer interaction activity history is used to calculate KPIs and understand who knows whom.

The following screenshot displays the widgets that are available out-of-the-box in the Relationship Analytics tab of a lead. Similar widgets are also available in Contact, Account, and Opportunity entities.

:::image type="content" source="media/relationship-analytics-tab.png" alt-text="Screenshot of the relationship analytics widgets available out-of-the-box." lightbox="media/relationship-analytics-tab-large.png":::

|Number|Widget  |Description  |Available for  |
|------|---------|---------|---------|
| 1 |Email engagement     | Use this widget to know how effectively your customers are engaging with the emails sent by your sellers, in terms of opening the email, attachments, and links. You can use this insight to coach sellers on effective email communication.        |Account, Contact, Lead, and Opportunity         |
| 2 |Customer interactions      | Use this widget to know whether the interaction between the seller and customer is balanced. The graph displays the number of interactions by sellers versus customers.            | Account, Contact, Lead, and Opportunity         |
| 3 |Relationship activities     | Use this widget to view the seller-customer interactions over the last 60 days and gain insight into interaction frequency and period of non-interaction. You can use this insight to define healthy interaction frequency.        | Account, Contact, Lead, and Opportunity         |
| 4 |Email sent/received ratio     | Use this widget to see if your sellers are staying on top of emails received from customers.          | Account, Contact, Lead, and Opportunity        |
| 5 |Most contacted and Most contacted by     | Use this widget to identify who is actively working on the account, lead, or opportunity from your end and customer's end.          | Account, Lead, and Opportunity   |

## Advanced relationship insights

Advanced relationship insights are available with the Sales Premium license and requires your administrator to enable and configure relationship intelligence. Your administrator can configures relationship intelligence to use the Exchange data. The insights will then be generated based on emails and meetings information in Exchange as well.   More information: [Enable relationship intelligence](enable-ri.md)

The following screenshot displays the advanced relationship insights that are available in the Relationship Analytics tab of a lead when. Similar widgets are also available in Contact, Account, and Opportunity entities.

:::image type="content" source="media/relationship-analytics-tab-advanced.png" alt-text="Screenshot of the advanced relationship analytics widgets available with Sales Premium." lightbox="media/relationship-analytics-tab-advanced.png"":::

|Number|Widget  |Description  |Available for  |
|------|---------|---------|---------|
| 1 |Summary     | Shows the summary of metrics and KPIs obtained for the records from your interactions with customers through emails, meetings, and phone calls. For example, *You have initiated 3 meetings more compared to the customer.*   |Account, Contact, Lead, Opportunity         |
| 1 |Email engagement     | Summarizes how your customer has interacted with the followed emails that your team has sent to them. Unfollowed emails are not included, so you must enable and use the email-engagement feature to see any information here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use email engagement to view message interactions](email-engagement.md).       |Account, Contact, Lead, Opportunity         |
| 2 |Customer interactions      | Shows the number of interactions initiated by you versus your customer's contacts. The graph displays the total number of activities initiated by members of your team and by the customer's contacts. The activities are broken down by general type, such as email, meetings, and phone calls. | Account, Contact, Lead, Opportunity         |
| 3 |Relationship activities     | Provides a detailed look at activities over 60 days, broken down by date and activity type, such as emails sent, emails received, meetings sent, meetings received, phone calls made, and phone calls received. Use this widget to view the seller-customer interactions over the last 60 days and gain insight into interaction frequency and period of non-interaction. You can use this insight to define healthy interaction frequency.        | Account, Contact, Lead, Opportunity         |
| 4 |Email sent/received ratio     | Shows the ratio of the number of emails sent by you and received by the customer related to a record.           | Account, Contact, Lead, Opportunity        |
| 5 |Most contacted and Most contacted by     | Shows the top three most active contacts for the deal from you and your customer's organizations, with details about the last time these contacts interacted.            | Account, Lead, and Opportunity   |
| 5 |Hourly investment     | Use this widget to compare the time spent by sellers versus the customer's contacts on a specific record.  For more information on how this value is calculated, see [Compute relationship analytics KPIs](relationship-analytics.md#step-3-compute-relationship-analytics-kpis)            | Account, Lead, and Opportunity   |
| 5 |Response time     |Shows the average amount of time taken by your sellers to respond to customer emails as compared to the time taken by your customers to respond.  [Connect to Exchange Online](/power-platform/admin/connect-exchange-online) to view data in this widget.         | Account, Contact   |
| 5 |Relationship health     |  Shows your overall relationship health with the customer, and includes the recent trend for the deal. <br>- **Next interaction.** Shows the date and time for the next activity that's scheduled for the record. If you have access to that activity, you'll also see its name or subject. The next and last interactions are only shown for opportunity and lead entities.<br> - **Last interaction.** Shows the date and time for the last activity that you completed for the record. If you have access to that activity, you'll also see its name or subject. The next and last interactions are only shown for opportunity and lead entities.          | Account, Contact, Lead, Opportunity   |
| 5 |Similar won deals     | Shows the list of similar opportunities that have been closed as won. The columns display activities count, time spent, response time, and the response ratio for each opportunity. You can select and open an opportunity to view what has worked better in a deal that was closed as won, and implement these observations in the current deal to help close it as well. The list is refreshed every seven days. To know how the similar won deals are identified, see [How are similar won deals identified?](faqs-sales-insights.md#similar-won-deals-fields)           |  Opportunity   |
| 5 |Customer interactions     | Use this widget to identify who is actively working on the account, lead, or opportunity from your end and customer's end.          |  Opportunity   |
