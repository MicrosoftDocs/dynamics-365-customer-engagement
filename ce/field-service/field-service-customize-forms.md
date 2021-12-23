---
title: "How to customize Field Service forms and best practices | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 01/05/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# How to customize Field Service forms

## 1. Understand the work order form

## 2. Create new fields

		a. Do not remove existing fields
		b. Do not edit existing fields
## 3. Use the existing work order form or create a new one

## 4. Use the existing work order form (recommended)

		a. Add your custom fields to a new tab
		b. https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-and-edit-forms
		c. Hide unwanted fields and move them away from the first tab
		d. Follow best practices

## 5. Create a new work order form
		a. https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/create-and-edit-forms
		b. Follow best practices 

## 6. Test your forms
		a. Performance bench mark
		b. Best practice violations 

## Best practices

	- Hide unwanted fields, do not remove them, and move them away from the first tab
	- Use Form component control
	- Move lesser used fields away from 
	- Minimize lookup controls
	- Minimize subgrids 
	- Do not add additional subgrids or lookups to main form tab
	- Design productive forms - https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/design-productive-forms
	- Design performant forms - https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/design-performant-forms

## Other considerations
	- Create forms for different roles
