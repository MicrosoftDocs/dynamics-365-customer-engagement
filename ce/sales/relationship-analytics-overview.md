---
title: Relationship analytics and KPIs overview  #Required; page title displayed in search results. Don't enclose in quotation marks.
description: Relationship analytics uses the activity history of a seller with a contact or account and calculates KPIs based on their interactions. The KPIs are available at various levels such as, contact, account, opportunity, and lead.  
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 01/30/2023
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

Basic relationship insights are generated out-of-the-box by using emails and appointments sent and received from Dynamics 365. The seller-customer interaction history is used to calculate KPIs and understand who knows whom. For information on how to view the insights, see [View relationship analytics and KPIs](relationship-analytics.md#view-relationship-analytics-and-kpis). 

The following screenshot displays the widgets that are available out-of-the-box in the **Relationship Analytics** tab of a lead. Similar widgets are also available in Contact, Account, and Opportunity entities.

:::image type="content" source="media/relationship-analytics-tab.png" alt-text="Screenshot of the relationship analytics widgets available out-of-the-box." lightbox="media/relationship-analytics-tab-large.png":::

|Number|Widget  |Description  |Available for  |
|------|---------|---------|---------|
| 1 |Summary   | Shows the summary of metrics and KPIs obtained for the records from your interactions with customers through emails, meetings, and phone calls. For example, *You have initiated 3 meetings more compared to the customer.*  |Account, Contact, Lead, Opportunity    |
| 2 |Most contacted and Most contacted by   | Shows the top three most active contacts for the deal from you and your customer's organizations, with details about the last time these contacts interacted.      | Account, Lead, and Opportunity  |
| 3 |Customer interactions   | Shows the number of interactions initiated by you versus your customer's contacts. The graph displays the total number of activities initiated by members of your team and by the customer's contacts. The activities are broken down by general type, such as email, meetings, and phone calls. | Account, Contact, Lead, Opportunity    |
| 4 |Email engagement   | Summarizes how your customer has interacted with the followed emails that your team has sent to them. Unfollowed emails are not included, so you must enable and use the email-engagement feature to see any information here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use email engagement to view message interactions](email-engagement.md).    |Account, Contact, Lead, Opportunity    |
| 5 |Email sent/received ratio   | Shows the ratio of the number of emails sent by you and received by the customer related to a record.      | Account, Contact, Lead, Opportunity    |
| 6 |Relationship activities   | Provides a detailed look at activities over 60 days, broken down by date and activity type, such as emails sent, emails received, meetings sent, meetings received, phone calls made, and phone calls received. Use this widget to view the seller-customer interactions over the last 60 days and gain insight into interaction frequency and period of non-interaction. You can use this insight to define healthy interaction frequency.    | Account, Contact, Lead, Opportunity    |

## Enhanced relationship insights

Enhanced relationship insights are available with the Sales Premium license and requires your administrator to enable and configure relationship intelligence. Your administrator can configure relationship intelligence to use the Exchange data as well. In this case, the insights will be generated based on emails and meetings information in Exchange and Dynamics 365.  More information: [Enable relationship intelligence](enable-ri.md)

For information on how to view the insights, see [View relationship analytics and KPIs](relationship-analytics.md#view-relationship-analytics-and-kpis).

The following screenshot displays the  enhanced  relationship insights that are available in the **Relationship Analytics** tab of a lead. Similar widgets are also available in Contact, Account, and Opportunity entities. For Opportunity records, the KPIs are compared with similar won deals. For more information see, [Relationship analytics with similar opportunities](relationship-analytics.md#relationship-analytics-with-similar-opportunities).

:::image type="content" source="media/relationship-analytics-tab-advanced.png" alt-text="Screenshot of the enhanced relationship analytics widgets available with Sales Premium." lightbox="media/relationship-analytics-tab-advanced.png":::


|Number|Widget  |Description  |Available for  |
|------|---------|---------|---------|
| 1 |Summary   | Shows the summary of metrics and KPIs obtained for the records from your interactions with customers through emails, meetings, and phone calls. For example, *You have initiated 3 meetings more compared to the customer.*  |Account, Contact, Lead, Opportunity    |
| 2 |Relationship health   |  Shows your overall relationship health with the customer, and includes the recent trend for the deal. <br>- **Next interaction.** Shows the date and time for the next activity that's scheduled for the record. If you have access to that activity, you'll also see its name or subject. The next and last interactions are only shown for opportunity and lead entities.<br> - **Last interaction.** Shows the date and time for the last activity that you completed for the record. If you have access to that activity, you'll also see its name or subject. The next and last interactions are only shown for opportunity and lead entities.     | Contact, Lead, Opportunity  |
| 3 |Most contacted and Most contacted by   | Shows the top three most active contacts for the deal from you and your customer's organizations, with details about the last time these contacts interacted.      | Account, Lead, and Opportunity  |
| 4 |Customer interactions   | Shows the number of interactions initiated by you versus your customer's contacts. The graph displays the total number of activities initiated by members of your team and by the customer's contacts. The activities are broken down by general type, such as email, meetings, and phone calls. | Account, Contact, Lead, Opportunity    |
| 5 |Hourly investment   | Use this widget to compare the time spent by sellers versus the customer's contacts on a specific record.  For more information on how this value is calculated, see [Compute relationship analytics KPIs](relationship-analytics.md#step-3-compute-relationship-analytics-kpis)      | Account, Lead, and Opportunity  |
| 6 |Email engagement   | Summarizes how your customer has interacted with the followed emails that your team has sent to them. Unfollowed emails are not included, so you must enable and use the email-engagement feature to see any information here. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use email engagement to view message interactions](email-engagement.md).    |Account, Contact, Lead, Opportunity    |
| 7 |Response time   |Shows the average amount of time taken by your sellers to respond to customer emails as compared to the time taken by your customers to respond.  [Connect to Exchange Online](/power-platform/admin/connect-exchange-online) to view data in this widget.    | Account, Contact  |
| 8 |Email sent/received ratio   | Shows the ratio of the number of emails sent by you and received by the customer related to a record.      | Account, Contact, Lead, Opportunity    |
| 9 |Relationship activities   | Provides a detailed look at activities over 60 days, broken down by date and activity type, such as emails sent, emails received, meetings sent, meetings received, phone calls made, and phone calls received. Use this widget to view the seller-customer interactions over the last 60 days and gain insight into interaction frequency and period of non-interaction. You can use this insight to define healthy interaction frequency.    | Account, Contact, Lead, Opportunity    |
| 10 |Similar won deals   | Shows the list of similar opportunities that have been closed as won. The columns display activities count, time spent, response time, and the response ratio for each opportunity. You can select and open an opportunity to view what has worked better in a deal that was closed as won, and implement these observations in the current deal to help close it as well. The list is refreshed every seven days. To know how the similar won deals are identified, see [How are similar won deals identified?](faqs-sales-insights.md#similar-won-deals-fields)      |  Opportunity  |

## How relationship analytics values are calculated

Relationship analytics values are derived from a careful analysis of the many related people, activities, companies, appointments, and email stored on your [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] and [!INCLUDE[pn_Microsoft_Exchange](../includes/pn-microsoft-exchange.md)] servers. The process for finding and calculating the scores is summarized in the following flow chart.  

![How relationship analytics are calculated](media/how-relationship-analytics-are-calculated.png "How relationship analytics are calculated")  

The following sections describe the function of each block in the flow chart.  

### Step 1: Find contacts of interest for the record

Relationship analytics is concerned with activities performed by the *people* associated with a given record. The first step in finding the relevant activities is to find out which contacts to include in the analysis. Relationship analytics also provides time-spent values for you, your team, and your customer's team, so the identity of who did what is important throughout the process.  

This table shows how the system finds contacts that have an interest in each type of record. Later, the system will look for activities associated with each contact and decide which of those activities should be included in KPI calculations for that record.  

|  Records | Internal contacts  |  External contacts |
|----------|--------------------|--------------------|
|  Account  | -  Any [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] user.|-  The **Primary Contact** for the account.<br />-  All contacts in the account's **Contacts** list. |
| Opportunity | -  The **Owner** of the opportunity record.<br />-  All users in the opportunity's **Sales Team** list. | -  The customer **Contact** listed for the opportunity.<br />-  All contacts in the opportunity's **Stakeholders** list.<br />-  The primary contact for the related **Account** record. |
|  Lead   | -  The **Owner** of the lead record. | -  Contact information in the lead's **Contact** section.<br />-  All contacts in the lead's **Stakeholders** list. |
|  Contact  | -  Any [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] user. | -  Contact information in the contact's **Contact** section.|

### Step 2: Link activities to the record

Once the system has identified contacts of interest, it looks for activities associated with each contact and then identifies which activities to include in the relationship analytics for the record you are looking at. It identifies relevant activities as follows:  

- **Regarding records.** Any activity that has its **Regarding** value set to the current record is explicitly assigned to it and will always be included in its relationship analytics, even if that activity isn't also associated with a contact of interest.  
- **Email messages.** Includes all metadata from messages where the email address (or a reference to the contact record) for a contact of interest is shown in the **To**, **Cc**, or **From** field.  
- **Appointments.** Includes all metadata from appointments where a contact of interest is shown in the **Required** or **Optional** fields.  
- **Phone calls.** Includes all calls where  a contact of interest is shown in the **From** or **To** fields.  

### Examples of how relevant activities are identified

Here are a few examples of how the rules outlined in the previous sections might be applied:  

- If you are assigned to a lead and register a phone call activity with one of the stakeholders for that lead, then that phone call will be counted in the KPIs for that lead. Other users who call that same stakeholder, but who are not assigned to the lead, will not have their calls counted in the KPIs for that lead.  
- If you are on the sales team for an opportunity and send an email regarding that opportunity to one of its stakeholders, then the metadata about that email will be counted in the KPIs for that account. An email from another user, who isn't on the team for that account, to that same stakeholder will not be counted for that opportunity.  
- If you attend a meeting with the primary contact for an account, then the metadata about that appointment will be counted in the KPIs for that account and for that contact. If that account is also associated with an opportunity, the appointment will only count for that opportunity if you are also **Assigned** to that opportunity (or are on its **Sales Team**) and if the appointment is set as **Regarding** that opportunity.  

### Step 3: Compute relationship analytics KPIs

After the system has found all the relevant activities, it's ready to calculate the KPIs and other analytics for each record. The following table summarizes the KPIs that are available.  

|Activity type|Initiated or completed by your team|Initiated or completed by the customer's team|  
|-------------|-----------------------------------------|---------------------------------------------------|  
|Emails|Total number<br /><br /> Total time spent<br /><br /> Time line (number per week)<br /><br /> Number of replies|Total number<br /><br /> Total time spent<br /><br /> Time line (number per week)<br /><br /> Number of replies<br /><br /> Interaction results for followed emails (opens, attachment views, and link views)|  
|Appointments|Total number<br /><br /> Total time spent by your team (if several team members were present at an appointment, then the duration is multiplied by the number of  team members  present)<br /><br /> Time line (number per week)|Total number<br /><br /> Total time spent (not multiplied by the number of customer contacts that were present)<br /><br /> Time line (number per week)|  
|Phone calls|Total number<br /><br /> Total time spent<br /><br /> Time line (number per week)|Total number<br /><br /> Total time spent<br /><br /> Time line (number per week)|  
|Overall (all activities)|Total time spent|Total time spent|  

> [!NOTE]
> Email interaction statistics are only provided for *followed emails*, which requires you to use the *email engagement* feature. For more information about how to create and send followed emails, see [Use email engagement to view message interactions](email-engagement.md).

For KPIs that report your team and your customer, the system finds durations by applying the rules outlined in the following table:  

|Activity type|Source of duration value|  
|-------------------|------------------------------|  
|Appointments|**Duration** field for the appointment record|  
|Calls|**Duration** field for the phone call record|  
|Emails|Estimated (2.5 minutes to read, 5 minutes to write)|  
|Other|**Duration** field for each record|  

> [!TIP]
> The time calculations for appointments are a bit special. The details are given in the previous tables, but here's an example to illustrate it.  <br/
> 
> If you hold an appointment where three members of your team (including you) meet with two members of your customer's team, and the appointment lasts for 30 minutes, then that appointment contributes to your time KPIs as follows:
> - **Time spent by my team**: *90 minutes* (30 minutes × 3 team members present)
> - **Time spent by the customer**: *30 minutes* (time isn't multiplied by customer participants)

### Step 4: Compute the relationship health and health trend

The overall relationship health score is calculated by collecting the relevant activities, and weighting the activity by type (which enables your admin to set some types of activities to count more than others). The result is normalized to produce a health score between 0 and 100, and the health characterized as *good* (for a score of 60-100), *fair* (40-59) or *poor* (0-39).  

**Note**: 

- Health scores are computed for leads if they are in an active state. This stops once they reach a qualified or disqualified state.
- Health scores are computed for opportunities if the opportunity is open and ignored if it’s won or lost.
- Health scores are computed for contacts irrespective of their state.  

Your administrator can choose which types of activities are most relevant for your business. By default, all types of activities count the same, but your admin can increase or decrease the contribution of each type by up to 50 percent. In addition, your admin can choose how often salespeople should contact a customer (such as once a week); this setting also affects the health score.  

![Relationship health weightings and frequency settings](media/relationship-analytics-settings-bottom.png "Relationship health weightings and frequency settings")  

In addition to the absolute health score, the system also reports the general trend (up, down, or neutral) based on the number and value of recent activities. The trend direction updates relatively slowly, so it might take a little while to indicate a recent increase or decrease  in activity.  