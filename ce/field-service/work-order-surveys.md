---
title: Work order completion surveys with Dynamics 365 Customer Voice
description: Send work order completion surveys from Dynamics 365 Customer Voice with Power Automate flows.
ms.date: 06/30/2023
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Work order completion surveys with Dynamics 365 Customer Voice

Send surveys and questionnaires to customers when a work order is completed to learn about customer satisfaction and how to improve onsite service with Dynamics 365 Customer Voice. Then use flows in Power Automate to automatically send a survey to the contact of a completed work order.

## Prerequisites

- Access and licenses to use Dynamics 365 Field Service, Dynamics 365 Customer Voice, and Power Automate.

## Create a survey with Dynamics 365 Customer Voice

Review the learning path to [Create surveys with Dynamics 365 Customer Voice](/training/paths/create-surveys/) and create a survey project to use with Field Service.

## Prepare the email template to send the survey

After creating the survey, [prepare and personalize an email template](/training/modules/send-customer-voice-surveys/1a-templates) to send the survey.

## Enable the Power Automate flow

Go to [Power Automate](https://make.powerautomate.com) and search for the template called [**Send a survey when a work order is completed or closed in Dynamics 365**](https://make.powerautomate.com/galleries/public/templates/7135fe34812745d5af513437a7657002/send-a-survey-when-a-work-order-is-completed-or-closed-in-dynamics-365?environment=839eace6-59ab-4243-97ec-a5b8fcc104e4).

Sign in to Microsoft Dataverse and Dynamics 365 Customer Voice and select **Continue** to begin editing the flow template.

Choose the Field Service environment name and validate the flow settings.

By default, the flow triggers when the **Work Order System Status** changes to **Open - Completed** or **Closed - Posted**.

## Next steps

- [Work order architecture](field-service-architecture.md)
- [Create a work order](create-work-order.md)
- [Work order lifecycle and system statuses](work-order-status-booking-status.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
