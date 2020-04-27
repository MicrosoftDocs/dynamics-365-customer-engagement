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

Oftentimes new Field Service capabilities are available as a preview before they are generally available. Preview features are not intended for production usage as they may be changed before becoming generally available. By installing and learning preview features you can better prepare for how your business can adopt them when they are generally available.

Follow the instrucitons in this article to manually add Field Service features in preview to your testing and development environment.

Installing a preview solution will install Field Service and preview features. If you do not have Field Service installed already


## Prerequisites

Find and note the Org ID of your Dynamics 365 environment you wish to add preview features to.

You can find this in **Settings > Customizations > Developer Resources**


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-orgid.png)




Ensure your PC computer has PowerShell installed. If not, [install it](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7).



## Steps to install preview features

Open PowerShell and Run as Administrator

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-powershell.png)



Run command below:

        install-module Microsoft.Xrm.OnlineManagementAPI -Scope CurrentUser -force 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-powershell-run-first-command.png)



Run command below and substitute your username. This username reflects a user with system administrator security role:

        $user = “user@org.onmicrosoft.com”   

Run command below and substitute your password

        $password = “password” 

Run command below:

        $cred = New-Object System.Management.Automation.PSCredential ($user, (ConvertTo-SecureString $password –ASPlainText –Force)) 


Next, check the topic on [Service URLs](https://docs.microsoft.com/en-us/powerapps/developer/common-data-service/online-management-api/get-started-online-management-api#service-url)

Run command below substituting the service URL based on your environment's geography.

        $url = “https://admin.services.crm.dynamics.com” 


Run command below:

        Get-CrmFlights -ApiUrl $url -Credential $cred  

If prompted, run software from an untrusted publisher by Entering "R".

> [!Note]
> If you get error: "\Microsoft.Xrm.OnlineManagementAPI.psm1 cannot be loaded because running scripts is disabled on this system" The solution is to Run the following PowerShell command: “Set-ExecutionPolicy -ExecutionPolicy AllSigned -Scope LocalMachine" 

If successful you will see a list of preview features. 

FieldServiceInspections_AprilPreviewFlight and flight id : e7ae2630-5868-4de2-8151-65bc7177ab67

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-powershell-previewlist.png)



Find the preview feature you would like to add to your environment and note the ID. In our example it is the ID for Field Service Inspections Flight

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-powershell-flightid-orgid.png)

Run command below by subsitituting 1) the ID of the preview feature found in PowerShell and 2) the orgID of your envorironment you noted in the beginning.

        Add-CrmFlightAudience -ApiUrl $url -FlightId "bdccdf3c-da3b-4a0f-8d0f-69c20e7256cb" -InstanceId "01f3f249-d269-415f-b036-e52701c75adf" -Credential $cred 

It will say **Added to Flight**

Repeat the last step for each Preview capability you would like to add to your org





> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-environment-before.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-admin2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-admin3.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-admin4.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-admin5.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-environment-before.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/preview-environment-after-powerapps-admin.png)

## Configuration considerations
## Additional Notes
