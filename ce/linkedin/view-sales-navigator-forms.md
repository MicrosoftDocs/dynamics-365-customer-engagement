---
title: "Sign in to LinkedIn Sales Navigator | Microsoft Docs"
description: "Sign in to LinkedIn Sales Navigator in Dynamics 365 to see lead information on forms."
keywords: "sign in, authenticate, sales navigator, customized form"
ms.date: 03/28/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 Version 9.x"
ms.assetid: efbe4fd6-a486-d97d-3b2c-8c4020e9d57b
author: m-hartmann
ms.author: mhart
manager: sakudes
topic-status: Drafting
---

# View Sales Navigator controls on forms

To use the [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator controls, you need be a [LinkedIn Sales Navigator Seat Holder](https://www.linkedin.com/help/sales-navigator/answer/50233/adding-or-removing-seat-holders-in-sales-navigator) and [a customizer needs to add them to the form](add-sales-navigator-controls-forms.md). 

## View controls on the form

1. In [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)], switch to the Unified Interface app (i.e Sales Hub). 

2. Go to the **Lead** entity and open one of the lead forms.

3. If your organization has added [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] controls to Lead forms, you'll find the controls embedded on the form.

> [!NOTE] 
> If you haven't signed in to [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator, select the Sign in button in the control and give the requested permissions to the app. 
> ![Sign in to LinkedIn Sales Navigator dialog box](media/sign-in-sales-navigator.png "Sign in to LinkedIn Sales Navigator dialog box")

## Work with the Sales Navigator controls

Both Lead and Account controls work by matching certain input parameters received from [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] with [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] member profiles and companies: 

- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Lead control: last name (primary), first name, e-mail, job title, company name 

- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Sales Navigator Account control: company name (primary), company website 

Once a match is found, subsequent loads are done through the record GUID association. Optionally, you can save recommended leads as new leads Sales Navigator.

> [!TIP]
> If the control does not load the correct profile on the first match, the user can fix the problem permanently by clicking on the “…” (more commands) menu, then on the **Not the right person** option and finding the correct match with the search interface. Additionally, you can send [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] members a request to connect or message them using InMail in Sales Navigator.
> ![More options with Sales Navigator control](media/more-options-sales-navigator.png "More options with Sales Navigator control")

### See also

[Overview for LinkedIn Sales Navigator solutions](integrate-sales-navigator.md)     
[Install and configure LinkedIn Sales Navigator Controls](install-sales-navigator.md)   
[Customize forms to show Sales Navigator controls](add-sales-navigator-controls-forms.md)    