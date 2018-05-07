---
title: "Implement General Data Protection Regulations in Voice of the Customer for Dynamics 365 | MicrosoftDocs"
description: "Learn how to implement General Data Protection Regulations in Voice of the Customer for Dynamics 365."
keywords: "implement GDPR in Voice of the Customer,Voice of the Customer GDPR "
ms.date: 05/07/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 689D3272-D2E5-4815-B723-6AE65BAA4838
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Implementing General Data Protection Regulations in Voice of the Customer

The General Data Protection Regulation (GDPR) is a legal act of the European Union (EU), which protects data for all individuals within the EU. With GDPR, customers can control the use of their personal data in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].

> [!NOTE]
> - The Voice of the Customer solution will be GDPR compliant if:
  >   - Your organization's Dynamics 365 version is 8.2.x or higher and you have installed Voice of the Customer version 9.0.1113.10 and higher.
  >   - Your organization's Dynamics 365 version is 8.1.x and you have installed Voice of the Customer version 8.3.1140.2 and higher.
> - Installing Voice of Customer version 8.3.1140.2 and higher or 9.0.1113.10 and higher does not guarantee GDPR compliance. Dynamics 365 should also be GDPR compliant.

As an administrator, your customers can contact you with the following requests regarding their data stored in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]:

- View
- Export
- Update
- Delete

The following entities in Voice of the Customer are related to account, contact lead, and user: response outcome, survey response, and survey activity. Following are scenarios and appropriate actions that you must take when a customer places a request:

**Scenario 1**: Customer requests to view their records

**Take this action**: Response outcomes and survey activities associated to a customer can be viewed in the related contact record.

If the customer has submitted the response to a survey activity/invite, you can view the related survey response in the related contact record.

However, if the customer has submitted the response anonymously, you must use an appropriate [Advanced Find](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/basics/save-advanced-find-search) query to search the customer record. For example, if you have collected email address of a customer as part of a survey, you must search all survey responses where the question response matches the customer’s email address.

If the customer requests to export the records, [export it to Excel](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/basics/export-data-excel) and share with the customer.

**Scenario 2**: Customer requests to update their record

**Take this action to update a survey activity**

You can view the related survey activities in the customer record (account, contact, lead) and then update the appropriate pipes.

For example, if you have created a workflow to send a personalized invite to customers on closure of a case, and you have used customer’s data in one or more pipes, you must update them manually.

**Take this action to update a survey response**

> [!NOTE]
> This is applicable if you have created personalized survey invites by using pipe data.

If the customer has submitted the response to a survey activity/invite, you can view the related survey response in the contact record and update it (only **Respondent** field in survey response).

However, if the customer has submitted the response anonymously, you must use [Advanced Find](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/basics/save-advanced-find-search) to search the survey response by using the personal information, and then update it.

**Scenario 3**: Customer requests to delete their record

**Take this action for survey response**

When you delete a customer record, survey responses are disassociated from the customer record. If a survey response contains personal information, you must delete the associated survey responses before deleting the customer record.

> [!NOTE]
> On deletion of a customer record, the **Respondent** field in the survey response will be set to empty if the customer name matches the value in the **Respondent** field. If you do not update the **Respondent** field manually as mentioned in the previous scenario, and delete the customer record, the value of the **Respondent** field will still be available in the survey response.

**Take this action for survey activity**

When you delete a customer record, and the customer record is included in the **Regarding** field in the survey activity, the corresponding survey activities are deleted.

When you delete a customer record, and the customer record is not included in the **Regarding** field in the survey activity, the corresponding survey activities are disassociated from the customer record. You must delete the associated survey activities before deleting the customer record.

**Scenario 4**: Customer requests to delete a survey response

**Take this action**: If the customer has submitted the response to a survey activity/invite, you can view the related survey responses in the contact record, and then delete the required survey response.

However, if the customer has submitted the response anonymously, use must use [Advanced Find](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/basics/save-advanced-find-search) to search the survey response by using the personal information, and then delete the survey response.

## Feedback entity

If you have enabled Feedback entity for a survey, you must take appropriate actions to view, export, update, or delete it.
