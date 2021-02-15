---
title: "Troubleshooting issues with email (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how to troubleshoot issues with email in Dynamics 365 Sales."
ms.date: 01/13/2021
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Troubleshooting issues with email

This article helps you troubleshoot and resolve issues related to emails in Dynamics 365 Sales.

## Email editor shows incorrect title in contextual email popup window

After upgrading to Wave 2 - 2020, the email editor shows incorrect title in contextual email popup window.

**Reason**

For out of the box email forms, the `onload` and `onchange` events are triggered that helps in updating email title and other attributes in the contextual email popup. If you've a custom email form or an unmanaged layer form, the `onload` and `onchange` events will not be available. Therefore, the email title is displayed incorrectly.

**Resolution**

To resolve this issue, you must add the `onload` and `onchange` events to the custom email forms.

1. [Create a new solution](https://docs.microsoft.com/powerapps/maker/common-data-service/create-solution).

2. Add the custom email form to the newly created solution.

3. [Export the solution](https://docs.microsoft.com/powerapps/maker/common-data-service/export-solutions).

4. Add the following code in the form's XML:

    ```
    <events>  <event name="onload" application="true" active="true"> 
    <InternalHandlers> <Handler functionName="Activities.Email.formOnload" libraryName="Activities/SystemLibraries/Email_main_system_library.js" handlerUniqueId="ecdfe4d8-d6d3-4d21-ab68-8ea75bb30a79" enabled="true" parameters="" passExecutionContext="true" /> 
    <Handler functionName="Activities.Email.NotifyPanelSubjectChange" libraryName="Activities/SystemLibraries/Email_main_system_library.js" handlerUniqueId="{706607A8-4424-4C9A-847A-602FC8035B48}" enabled="true" parameters="" passExecutionContext="true" solutionaction="Added"/> 
    </InternalHandlers>  </event>
    <event name="onchange" application="true" active="true" attribute="subject" solutionaction="Added"><Handlers> 
    <Handler functionName="Activities.Email.NotifyPanelSubjectChange" libraryName="Activities/SystemLibraries/Email_main_system_library.js" handlerUniqueId="{706607A8-4424-4C9A-847A-602FC8035B48}" enabled="true" parameters="" passExecutionContext="true"/></Handlers></event></events>
    <clientresources> <internalresources> <clientincludes> <internaljscriptfile src="$webresource:Activities/SystemLibraries/Email_main_system_library.js" />    </clientincludes>  </internalresources></clientresources>
    ```

5. [Import the solution](https://docs.microsoft.com/powerapps/maker/common-data-service/import-update-export-solutions).

### See also

[Dynamics 365 Sales troubleshooting guide](troubleshooting.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]