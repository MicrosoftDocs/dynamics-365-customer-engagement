---
title: "Configuring and customizing the Field Service mobile app | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 10/19/2018
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
  - enduser
search.app: 
  - D365CE
  - D365FS
---

# Customizing and configuring the Field Service mobile app

After setting up the Field Service mobile application, it is common to customize and configure the mobile user interface and data based on your business needs. 

The [Woodford guide](https://www.resco.net/downloads/Woodford_Guide.pdf) provides guidance for customizing and configuring the mobile application via the Woodford solution. 

The [Field Service mobile project](https://go.microsoft.com/fwlink/p/?linkid=836310) is a template of customizations and configurations to begin with and should be imported into Woodford.

## Mobile customization examples

The most common customizations are to edit the home screen, fields, forms, and views field technicians see when logged into the Field Service mobile app. Additionally, these customizations can differ based on the security roles of logged in users.

### Home screen
Edit the entities displayed upon logging into the mobile app

> ![Screenshot of mobile home](media/mobile-home.png)

### Views
After selecting an entity, edit the view of records displayed including fields, size, and color.
> ![Screenshot of mobile view](media/mobile-account-view.png)

### Fields and forms
After selecting a record in the view, edit the forms including fields and size. 
> ![Screenshot of mobile form](media/mobile-account-form.png)

### Offline HTML and JavaScript

Moving beyond the traditional entity-view-form layout, mobile customizers can replace the entire mobile interface using custom HTML and JavaScript that works offline.

> ![Screenshot of offline html example on the mobile app](media/mobile-offline-html-example.png)

## Mobile configuration examples

**Security-** users of the mobile app have access to data based on their Dynamics 365 security roles; however, mobile administrators can further restrict security at the entity and field level.

**Sync options-** configure when data is sent from the device to the server and vice versa. Common examples include each time the mobile app is launched or each time a field is updated.

**Sync filters-** configure which subset of server data is downloaded locally to the device when in offline mode. Offline mode is typically triggered manually or automatically when there is no internet access.

**Workflows-** create mobile workflows called form rules. Common examples include auto-populating data when specific fields are edited or displaying warning messages in the mobile interface.

**Commands-** configure actions and workflows to be performed when custom buttons (commands) are selected.

## See also
[Install Field Service with mobile](../field-service/install-field-service.md)

[Resco support guides](https://www.resco.net/support/guides/)
