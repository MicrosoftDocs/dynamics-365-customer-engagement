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

Field Service inspections are a digital form that technicians use to quickly and easily answer a list of questions as part of a work order.  for a check list, protocol, audits process, or assessment.  

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

## Additional Notes
vs. powerapps? - ok if have small handful, this inspections is better for more than 10
	- Difference between inspections and incidents and service tasks
	- Limits?
	- Known limitations 
Only single response , need to add multiple incidents