---
title: "Manage leads in Dynamics 365 for Sales Professional | MicrosoftDocs"
description: "Track your potential buyers as leads in Dynamics 365 for Sales Professional."
keywords: ""
ms.date: 04/05/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.x"
ms.assetid: dcf30d6e-d973-4902-9a6a-df9291119462
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Manage leads in Dynamics 365 for Sales Professional

In Dynamics 365 for Sales Professional, leads are potential sales. In other words, a lead is a potential customer who must be qualified or disqualified as a sales opportunity. When a lead is qualified, it can be converted to an opportunity, account, or contact.

You can collect leads from many different sources. For example, you can generate sales leads from marketing campaigns, inquiries from your website, or mailing lists.

When you create a lead, there are system-required fields to fill out. But other data, such as e-mail addresses, the source of the lead, and specific product interests, can also help your sales staff in following up with the customers.

## Create a lead

1.  In the site map, select **Leads**.

2.  Select **New**.

    The Lead form opens.

    ![Lead form](media/lead-form.png "Lead form")

3.  In the **Summary** tab, enter your lead’s contact and company details.

4.  In the **Timeline** section, add any notes and activities (for example, phone calls or emails) related to this lead.

5.  In the **Stakeholders** section, select **More Commands** ![More Commands button](media/more-commands-button.png "More Commands button"), and then select **New Connection** to add a contact as a stakeholder. A *stakeholder* is a key contact at the account who will be involved in decision-making.

    In the **Lookup Records** dialog box, enter a name or select the Lookup icon to choose from a list of suggestions. When you've entered the name you want, select **Add**. To create a new contact, select **New**. By default, the contact you add is assigned the Stakeholder role. Select the role corresponding to the contact to choose a different role such as **Decision Maker** or **Technical Buyer**.

6.  In the **Details** tab, enter information about your lead’s industry and preferred contact method.

7.  Select the **Save** button in the lower-right corner of the screen.

## Qualify and convert a lead to an opportunity

If your lead has potential to become a sale, you can qualify the lead to an opportunity. When you qualify a lead, a new record to represent the lead as an opportunity is created. Any notes on a lead record do not transfer to the opportunity record. The notes remain with the originating lead record.

1.  Go to **Leads**.

2.  In the list of leads, open the lead you want to qualify and convert.

3.  In the **Qualify** section of the sales process bar, type in all applicable information.

4.  Select **Qualify** at the top of the **Lead** screen.

    You must also select the currency in which to calculate the opportunity.

5.  Select the **Save** button at the lower-right corner of the screen.

To qualify multiple leads at once, go to the list of lead records. Select the check boxes next to all the leads that you want to qualify, and then select **Qualify** at the top of the screen.

## Disqualify a lead

When you decide that a lead will not turn into an opportunity, you can
disqualify it and still have an audit trail for your sales process. You can reactivate the record, including any attachments and notes, without having to re-enter all the data if the lead contacts you in the future. Deleting the record also removes any attachments and notes.

To disqualify, select the lead, and on the command bar, select  **Disqualify**.

### See also

[Develop sales from lead to cash in Dynamics 365 for Sales Professional](develop-sales-lead-to-cash-sales-professional.md)  
[Overview of Dynamics 365 for Sales Professional](sales-professional-overview.md)
