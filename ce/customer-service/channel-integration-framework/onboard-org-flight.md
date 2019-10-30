---
title: "Onboard your organization to Dynamics 365 Channel Integration Framework version 2.0 flight | MicrosoftDocs"
description: "Learn about managing notification templates in Dynamics 365 Channel Integration Framework"
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 10/18/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 8E27477D-460D-4559-9379-FEC04129CF5E
ms.custom: 
---
# Preview: Onboard your organization to Dynamics 365 Channel Integration Framework version 2.0 flight

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

Before you go to AppSource to install Dynamics 365 Channel Integration Framework version 2.0, you will need to onboard your organization to the version 2.0 flight. Follow these steps to do that.

1. Launch Windows Powershell Prompt and enter the list of commands given below.

2. `install-module Microsoft.Xrm.OnlineManagementAPI -Scope CurrentUser -force`

3. `$user = “<your-username>”`

4. `$password = “<your-password>”`

5. `$cred = New-Object System.Management.Automation.PSCredential ($user, (ConvertTo-SecureString $password –ASPlainText –Force))`

6. Create a `url` variable and assign it the Service URL based on the region of your organization.  You can find the value for your region here: [Get started with Online Management API](/powerapps/developer/common-data-service/online-management-api/get-started-online-management-api). `$url = “https://admin.services.crm.dynamics.com”` 

7. Get the CIFramework_Preview_Flight Id by executing the following command: `Get-CrmFlights -ApiUrl $url -Credential $cred`

8. Add your organization to the flight by executing the following command: `Add-CrmFlightAudience -ApiUrl $url -FlightId "<flight Id>" -InstanceId "<org Id>" -Credential $cred`

If you want to opt out of the public preview flight, execute the following command: `Remove-CrmFlightAudience -ApiUrl $url -Credential $cred -FlightId "<flight Id>" -InstanceId "<org Id>"`

After your organization is added to the flight, you can proceed to install the Dynamics 365 Channel Integration Framework Version 2.0 solution from AppSource.

> [!NOTE]
> The base version of Dynamics 365 Channel Integration Framework version 2.0 solution is 9.2.0.49. Upgrades to the solution take place through a patch solution that is shipped within the package. This means that installation of public preview updates will fail if you have a higher version of the Dynamics 365 Channel Integration Framework package installed. In this case, delete the original Dynamics 365 Channel Integration Framework solution from your organization, and then reinstall the package from AppSource.
>
> You will not be able to see available upgrades for the Dynamics 365 Channel Integration Framework solution in the Dynamics 365 admin center if your solution version is 9.2.0.49. You can get the latest upgrades from AppSource.

## See also

[Get Dynamics 365 Channel Integration Framework](get-channel-integration-framework.md)
