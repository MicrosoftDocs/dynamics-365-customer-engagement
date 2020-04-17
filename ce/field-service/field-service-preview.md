---
title: "Install preview features for Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 04/17/2020
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

# Install preview features for Field Service

Oftentimes new Field Service capabilities are available as a preview before they are generally available. Preview features are not intended for production usage as they may be changed before becoming generally available. By installing and learning preview features you can better prepare for how your business can adopt them when they are generaly available.

Follow the instrucitons in this article to manually add Field Service features in preview to your testing and development environment.


## Prerequisites

Find and note the Org ID of your Dynamics 365 environment you wish to add preview features to.

You can find this in **Settings > Customizations > Developer Resources**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-orgid.png)


Ensure your PC computer has PowerShell installed. If not, [install it](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7).

> [!Note]
>

## Steps to install preview features

Open PowerShell and Run as Administrator

install-module Microsoft.Xrm.OnlineManagementAPI -Scope CurrentUser -force 

$user = “aurorauser01@capintegration01.onmicrosoft.com”   

$password = “aZa~gr3^}U” 

$cred = New-Object System.Management.Automation.PSCredential ($user, (ConvertTo-SecureString $password –ASPlainText –Force)) 

$url = “https://admin.services.crm.dynamics.com” 

(Get the url from here based on the region(https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/online-management-api/get-started-online-management-api)) 

Get-CrmFlights -ApiUrl $url -Credential $cred  

(Here, we should be able to see the FieldServiceInspections_AprilPreviewFlight in the list)
Add-CrmFlightAudience -ApiUrl $url -FlightId "e7ae2630-5868-4de2-8151-65bc7177ab67" -InstanceId "c87315d7-53ca-43f5-8b6f-0441ffa16a9e" -Credential $cred 



## Configuration considerations
## Additional Notes
