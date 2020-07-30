---
title: "Work order completion surveys with Customer Voice (Forms Pro) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 09/30/2020
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: krbjoran
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: FieldServiceDave
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Work order completion surveys with Customer Voice (Forms Pro)

Send surveys and questionnaires to customers when a work order is completed to learn about customer satisfaction, how to improve onsite service, and more! With Customer Voice (formerly Forms Pro) you can create custom surveys based on your business needs and with Power Automate flow templates you can automatically send those surveys to the primary contact of the Field Service Work Order. 


## Prerequisites

Access and licenses to use Dynamics 365 Field Service, Customer Voice (formerly Forms Pro), and Power Automate flow.
> [!Note]
>

## Step 1: Create a survey with Customer Voice

First create a survey that you would like to send upon completion of a work order.

If you are an existing Customer Voice user, use [https://forms.office.com](https://forms.office.com) to sign in to Forms Pro. To purchase Forms Pro licenses, see [Purchase Microsoft Forms Pro](https://docs.microsoft.com/en-us/forms-pro/purchase).


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-new-form.png)

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-new-form-q1.png)

## Email

Send > Email > template


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-new-form-email-template.png)

## Flow template

https://us.flow.microsoft.com/en-us/galleries/public/templates/7135fe34812745d5af513437a7657002/send-a-survey-when-a-work-order-is-completed-or-closed-in-dynamics-365/

Environment




> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-flow-template.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-flow-template1.png)

Survey

Email template


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-flow-template2.png)

## Create work order


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-email-receive.png)

## Complete work order


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-work-order-after.png)

## Receive survey


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/work-order-survey-email-receive.png)

## Configuration considerations
## Additional Notes