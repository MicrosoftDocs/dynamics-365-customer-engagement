---
title: "Sign in to LinkedIn Sales Navigator | Microsoft Docs"
description: "Sign in to LinkedIn Sales Navigator in Dynamics 365 to see lead information on forms."
keywords: "sign in, authenticate, sales navigator, customized form"
ms.date: 03/26/2018
ms.assetid: efbe4fd6-a486-d97d-3b2c-8c4020e9d57b
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# View Sales Navigator controls on forms

To use the LinkedIn Sales Navigator controls, you need be a [LinkedIn Sales Navigator Seat Holder](https://www.linkedin.com/help/sales-navigator/answer/50233/adding-or-removing-seat-holders-in-sales-navigator) and [a customizer needs to add them to the form](add-sales-navigator-controls-forms.md). 

## View controls on the form

1. In Dynamics 365, switch to the Unified Interface app (i.e Sales Hub). 

2. Go to the **Lead** entity and open one of the lead forms.

3. If your organization has added LinkedIn controls to Lead forms, you'll find the controls embedded on the form.

> [!NOTE] 
> If you haven't signed in to LinkedIn Sales Navigator, select the Sign in button in the control and give the requested permissions to the app. 
> ![Image alt text](media/sign-in-sales-navigator.png "Image hover text")

## Work with the Sales Navigator controls

Both Lead and Account controls work by matching certain input parameters received from Dynamics 365 with LinkedIn member profiles and companies: 

- LinkedIn Sales Navigator Lead control: last name (primary), first name, e-mail, job title, company name 

- LinkedIn Sales Navigator Account control: company name (primary), company website 

Once a match is found, subsequent loads are done through the record GUID association. Optionally, you can save recommended leads as new leads Sales Navigator.

> [!TIP]
> If the control does not load the correct profile on the first match, the user can fix the problem permanently by clicking on the “…” (more commands) menu, then on the **Not the right person** option and finding the correct match with the search interface. Additionally, you can send LinkedIn members a reqeust to connect or message them using InMail in Sales Navigator.
> ![Image alt text](media/more-options-sales-navigator.png "Image hover text")

### See also
[Learn how to install and configure the solution.](install-sales-navigator.md)     
[Find out how to customize forms to see Sales Navigator controls.](add-sales-navigator-controls-forms.md)    