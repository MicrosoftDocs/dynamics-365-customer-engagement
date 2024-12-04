---
title: Relationship analytics KPI calculations 
description: Learn how relationship analytics KPIs are calculated in Dynamics 365 Sales.   
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual 
ms.date: 07/25/2024
ms.custom: bap-template
---

# Relationship analytics KPI calculations

Relationship analytics values are derived from an analysis of the related people, activities, companies, appointments, and emails stored in Dynamics 365 Sales and, for Sales Premium customers, Exchange servers. [View relationship analytics and KPIs](relationship-analytics.md).

The following diagram summarizes the process for finding and calculating relationship scores:

:::image type="content" source="media/how-relationship-analytics-are-calculated.png" alt-text="Block diagram illustrating the components of relationship analytics calculations.":::

The following sections describe the function of each block in the flow chart.  

## Find contacts of interest for the record

Relationship analytics is concerned with activities performed by the *people* associated with a given record. The first step in finding relevant activities is to determine which people to include in the analysis. Relationship analytics also provides time-spent values for you, your team, and your customer's team, so the identity of who did what is important throughout the process.  

The following table describes how the system finds contacts that have an interest in each type of record. Later, the system looks for activities associated with each contact and decides which ones should be included in KPI calculations for that record.  

| Records | Internal contacts | External contacts |
|----------|--------------------|--------------------|
| Account | Any Dynamics 365 Sales user | - The **Primary Contact** for the account<br/>- All contacts in the account's **Contacts** list |
| Opportunity | - The **Owner** of the opportunity record<br/>- All users in the opportunity's **Sales Team** list | - The customer **Contact** listed for the opportunity<br/>- All contacts in the opportunity's **Stakeholders** list<br/>- The primary contact for the related **Account** record |
| Lead  | The **Owner** of the lead record | - Contact information in the lead's **Contact** section<br/>- All contacts in the lead's **Stakeholders** list |
| Contact | Any Dynamics 365 Sales user | Contact information in the contact's **Contact** section |

## Link activities to the record

After the system has identified contacts of interest for the record, it looks for activities associated with each contact and then identifies which ones to include in the relationship analytics. It identifies relevant activities as follows:  

- **Regarding records:** Any activity that has its **Regarding** value set to the current record is explicitly assigned to it and is always included in its relationship analytics, even if that activity isn't also associated with a contact of interest.  
- **Email messages:** Includes all metadata from messages where the email address (or a reference to the contact record) of a contact of interest appears in the **To**, **Cc**, or **From** box.  
- **Appointments:** Includes all metadata from appointments where a contact of interest appears in the **Required** or **Optional** box.  
- **Phone calls:** Includes all calls where a contact of interest appears in the **From** or **To** box.  

Here are a few examples of how relevant activities are identified:  

- If you're assigned to a lead and you register a phone call activity with one of the stakeholders for the lead, then the phone call is counted in the KPIs for the lead. Other users who call the same stakeholder, but who aren't assigned to the lead, aren't counted in the lead's KPIs.  
- If you're on the sales team for an opportunity and you send an email regarding the opportunity to one of its stakeholders, then the email metadata is counted in the KPIs for the account. Emails to the same stakeholder from other users who aren't on the account team aren't counted for that opportunity.  
- If you attend a meeting with the primary contact for an account, then the metadata about the appointment is counted in the KPIs for the account and for the contact. If the account is also associated with an opportunity, the appointment only counts for the opportunity if you're also **Assigned** to the opportunity, or are on its **Sales Team**, and if the appointment is set as **Regarding** that opportunity.

## Compute relationship analytics KPIs

After the system has found all the relevant activities, it's ready to calculate the KPIs and other analytics for each record. The following table summarizes the KPIs that are available.

| Activity type | Initiated or completed by your team | Initiated or completed by the customer's team |  
|-------------|-----------------------------------------|---------------------------------------------------|  
| Emails | Total number<br/>Total time spent<br/>Time line (number per week)<br/>Number of replies | Total number<br/>Total time spent<br/>Time line (number per week)<br/>Number of replies<br/>Interaction results for followed emails (opens, attachment views, and link views) |  
| Appointments | Total number<br/>Total time spent by your team (if several team members were present at an appointment, then the duration is multiplied by the number of team members present)<br/>Time line (number per week) | Total number<br/>Total time spent (not multiplied by the number of customer contacts that were present)<br/>Time line (number per week) |  
| Phone calls | Total number<br/>Total time spent<br/>Time line (number per week) | Total number<br/>Total time spent<br/>Time line (number per week) |  
| Overall (all activities) | Total time spent | Total time spent |  

> [!NOTE]
> Email interaction statistics are only provided for followed emails, which requires you to use the email engagement feature. [Learn how to use email engagement to view message interactions](email-engagement.md).

For KPIs that report your team and your customer, the system finds durations by applying the rules outlined in the following table.

| Activity type | Source of duration value |  
|-------------------|------------------------------|  
| Appointments | **Duration** field for the appointment record |  
| Calls | **Duration** field for the phone call record |  
| Emails | Estimated (2.5 minutes to read, 5 minutes to write) |  
| Other | **Duration** field for each record |  

Here's an example of how the duration KPI is calculated for appointments. You hold an appointment where you and two members of your team meet with two members of your customer's team. The appointment lasts 30 minutes. The appointment contributes to your time KPIs according to the following calculations:

- **Time spent by your team**: *90 minutes* (30 minutes × 3 team members present)
- **Time spent by the customer**: *30 minutes* (time isn't multiplied by customer participants)

## Compute the relationship health and health trend

The overall relationship health score is calculated by weighting relevant activities by type. The result is normalized to produce a health score between 0 and 100, with the health of the relationship characterized as *good* (a score of 60-100), *fair* (40-59) or *poor* (0-39).  

- Health scores are computed for active leads. Leads that are in a qualified or disqualified state are ignored.
- Health scores are computed for open opportunities. Opportunities that are won or lost are ignored.
- Health scores are computed for contacts regardless of their state.  

Your administrator can choose which types of activities are most relevant for your business. By default, all types of activities count the same. Your admin can make some types of activities count more than others by increasing or decreasing the contribution of a type by up to 50 percent.

In addition, your admin can choose how often salespeople should contact a customer, such as once a week. This setting also affects the health score.

:::image type="content" source="media/relationship-analytics-settings-bottom.png" alt-text="Screenshot of relationship health weightings and frequency settings.":::

In addition to the absolute health score, the system also reports the general trend (up, down, or neutral) based on the number and value of recent activities. The trend direction updates relatively slowly, so it might take a little while to reflect a recent increase or decrease in activity.
