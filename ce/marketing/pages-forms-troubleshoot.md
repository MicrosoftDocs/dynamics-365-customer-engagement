---
title: "Troubleshoot pages and forms (Dynamics 365 Marketing) | Microsoft Docs"
description: "Troubleshooting and frequently asked questions for pages and forms in Dynamics 365 Marketing."
ms.date: 07/08/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Troubleshoot pages and forms

## Forms

### Form capturing is not creating leads or contacts

If the form capture tool is not creating leads or contacts, follow the troubleshooting steps below.

- Open the page where the form is hosted in the browser.
- Open DevTools and go to the **Network** tab. Filter for "/t/c/", the request should look like this:
``
https://5fe34c1f8d1dd6db05ad78a249c09712.svc.dynamics.com/t/c/IvgkEwv4GIs1ScAxmzz6GMONjZFNON3OMriPhE_eLxv/rVsp5lpmbDK_yMF80q5inAQeM73bcYKkbmiHLOak/ISUqp_Lw?trackwebsitevisited=true&ad=https%3A%2F%2Fwww.contoso.com%2Fcontact%2F&rf=&id=9430316937
``
- Check if there is a successful response that contains captured forms (see image below).
  - If the response is an error, there is an issue with the setup.
  - Format the response by selecting **{}** on the bottom left of the console window.
  - Look for `captureForms` in the response.
  - If `captureForms` is missing, there is a setup issue. Likely, the form is captured on a different URL.
- Check `formId`. Check that the values match the form. First, try to match by the ID. If the ID is missing, match by the name/action/method combo. Capturing the code writes the following line to the console: `Missing forms - []`. If there is something between **[** and **]**, the system was unable to find forms matching the capturing definition.
  - It is also possible that some identification data changed. You may be able to revert and prevent changes.
  - If changes cannot be prevented, the following attributes help:
    - `data-find-by-id-fallback-to-action="true"` to ignore the ID attribute of the form and use the name/action/method combo.
    - `data-find-by-id-ignore-prefix-to="delimiter"` to ignore prefixes up to the delimiter.
    - `data-find-by-id-ignore-suffix-from="delimiter"` to ignore suffixes starting with the delimiter.
- Check that the allowed domains match the hosting domain:
> [!div class="mx-imgBorder"]
> ![Allow hosting domains comparison screenshot.](media/pages-form-troubleshoot-allowed-hosting.png "Allow hosting domains comparison screenshot")
  - If the allowed domains and hosting domain do not match, there is a domain allow listing issue.
- Next, submit the form and check that the inputs are valid.
- Check the DevTools console.
  - If you see: `Skipping sending form to CRM`, "preventDefault" is set on the form submit event and data-ignore-prevent-default="true" is not present in configuration element. More details here: [Form capturing behavior customization](/dynamics365/marketing/developer/marketing-form-client-side-extensibility.md#form-capturing-behavior-customization).
    - If all submissions need to be captured, set `data-ignore-prevent-default"="true"`.
    - If there is some custom validation logic and not all submissions should be sent to Dynamics 365, a JavaScript API should be used. Add `data-no-submit="true"` and add call to `sendFormCaptureToCrm` to the event handler.

**Sample /t/c/ (correlation) response:**

> [!div class="mx-imgBorder"]
> ![Sample /t/c response screenshot.](media/pages-forms-troubleshoot-capture-example.png "Sample /t/c response screenshot")