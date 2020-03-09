---
title: "Field Service Inspections | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 03/09/2020
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

# Add inspections to Work Orders

Field Service inspections are a digital form that technicians use to quickly and easily answer a list of questions as part of a work order. The list of questions are often a safety protocol, pass and fail tests for a customer asset, an interview with a customer, or other various audits and assessments that are performed before, during, or after a work order.

Compared to using Work Order Incident Types and Service Tasks, using Inspections has the added benefits of:

- **Easy to create** - administrators can quickly create inspection questions with a drag and drop interface without the need to create new entities and fields.
- **Easy to fill out** - technicians can quickly enter answers for each inspection question and save all of them with one click rather than having to open and close multiple records.
- **More felxible and robust** - Field Service Inspections have many options for 

Benefits
- esay to create - dont need to create entities and fields for each inspection
- easy to fill out - dont need to open and save and close a bunch of records, only one
- powerful; - Questions, images, attachments, mandatory fields
- report on answers

Process
- create template
- Add to work order
- complete inspection
- View and analyze results


## Prerequisites
Public preview April 2020

Minimum supported CRM version for Inspections to work is 9.1.0000.15015

Work orders set up with data

> [!Note]
>

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Create inspection template


> [!Note]
> Cannot create inspection on mobile

## Associate inspection to service task type
## Add inspection to work order
## Perform inspection 
		
## View responses

## Configuration considerations
- is each question in CDS?
- branching logic
- reporting on responses
- FS Mobile
- PDF capability for reporting
- inspecting X assets at a location

## Additional Notes
vs. powerapps? - ok if have small handful, this inspections is better for more than 10
	- Difference between inspections and incidents and service tasks
	- Limits?
	- Known limitations 
Only single response , need to add multiple incidents