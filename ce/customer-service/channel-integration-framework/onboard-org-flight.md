---
title: "Onboard your organization to Channel Integration Framework Version 2.0 flight | MicrosoftDocs"
description: "Learn about managing notification templates in Dynamics 365 Channel Integration Framework"
keywords: ""
author: susikka
ms.author: susikka
manager: shujoshi
applies_to: 
ms.date: 10/17/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 8E27477D-460D-4559-9379-FEC04129CF5E
ms.custom: 
---
# Onboard your organization to Channel Integration Framework Version 2.0 flight

Follow the steps given below to onboard your organization to Channel Integration Framework Version 2.0 flight.

1. Launch Windows Powershell Prompt and enter the list of commands given below.

2. `install-module Microsoft.Xrm.OnlineManagementAPI -Scope CurrentUser -force`

3. `$user = “<your-username>”`

4. `$password = “<your-password>”`

5. `$cred = New-Object System.Management.Automation.PSCredential ($user, (ConvertTo-SecureString $password –ASPlainText –Force))`

6. Create a `url` variable and assign it the Service URL based on the region of your organization.  You can find the value for your region here: [Get started with Online Management API](/powerapps/developer/common-data-service/online-management-api/get-started-online-management-api). `$url = “https://admin.services.crm.dynamics.com”` 

7. Get the CIFramework_Preview_Flight Id by executing the following command. `Get-CrmFlights -ApiUrl $url -Credential $cred`

8. Add your organization to the flight by executing the following command. `Add-CrmFlightAudience -ApiUrl $url -FlightId "<flight Id>" -InstanceId "<org Id>" -Credential $cred`

If you want to opt out of the public preview flight, execute the following command. `Remove-CrmFlightAudience -ApiUrl $url -Credential $cred -FlightId "<flight Id>" -InstanceId "<org Id>"`.

After your organization is added to the flight, you can proceed to install the Channel Integration Framework Version 2.0 solution from AppSource.

## See also

[Get Channel Integration Framework](get-channel-integration-framework.md)