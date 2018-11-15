---
title: "Pass Dynamics 365 URL to widget library| Microsoft Docs"
description: "Learn the architecture overview of Channel Integration Framework (CIF) for Microsoft Dynamics 365."
keywords: ""
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-cross-app"
ms.custom:
  - "dyn365-a11y"
  - "dyn365-developer"
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: CBA9588C-5CF7-4FE5-A92E-6091FD8940EC
author: susikka
ms.author: susikka
manager: shujoshi
---

# Pass Dynamics 365 URL to widget library

There are two ways to pass Dynamics 365 URL to widget library:

### 1. Add attributes to the script tag

The widget provider will have to add the following attributes to the script tag that loads `msdyn_cilibrary.js` to pass the Dynamics 365 domain:

`data-cifid: CIFMainLibrary` <br />
`data-crmurl: <CRM domain name>`

#### Example

```html
<script type="text/javascript" src="https://crmorg.crm.dynamics.com/webresources/Widget/msdyn_ciLibrary.js" onload="ciLoadDone();" data-crmurl="https://crmorg.crm.dynamics.com" data-cifid="CIFMainLibrary">
</script>
```
### 2. Add a URL parameter

Another method is to pass a parameter in the URL, like `ucilib=https://<crm_domain name>`.