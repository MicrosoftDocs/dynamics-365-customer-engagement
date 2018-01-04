---
title: "Avoid usage of window.top | MicrosoftDocs"
description: "Avoid usage of window.top"
ms.date: 11/30/2017
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 75280d3b-c6a9-4c67-b8a5-0d1d0fb43af8
author: "mhuguet"
ms.author: "michu"
manager: "austinj"
---
# Avoid usage of window.top

**Applies to**: [!include[](../../includes/pn-crm-9-0-0-online.md)]

**Category**: Supportability, upgrade readiness, online migration

**Impact potential**: High

<a name='symptoms'></a>

## Symptoms

- The following script error will be displayed to users or included in your error logs: `Error: Blocked a frame with origin "https://<yourinstance>.dynamics.com" from accessing a cross-origin frame.`
- Customizations might not behave correctly in the context of [!include[](../../includes/pn-dyn-365-app-outlook.md)], [!include[](../../includes/pn-dynamics-crm.md)] for phones and tablets, or an external application that hosts [!include[](../../includes/pn-dynamics-crm.md)] within an iframe.

 > [!NOTE]
 > There might be some scenarios where error handling masks the error and continues script processing, causing unexpected behavior.

<a name='guidance'></a>

## Guidance

Avoid using `window.top` in scripts running within the context of [!include[](../../includes/pn-dyn-365-app-outlook.md)], [!include[](../../includes/pn-dynamics-crm.md)] for phones and tablets, or an external application that hosts [!include[](../../includes/pn-dynamics-crm.md)] within an iframe. Even if these scenarios don't currently apply to your organization, you should avoid using `window.top` or guard against this issue.

 > [!IMPORTANT]
 > Usage of `window.parent` or variations of the parent hierarchy (for example,`window.parent.parent`) can cause the same symptoms.

The following are the recommended approaches:

- Avoid usage of the window.top object altogether.

- If using `window.top` is the only available option, first test to determine whether `window.top` is accessible by using the script below. If it's not available, provide alternate logic or a fallback user experience.

  > [!NOTE]
  > Although we recommend that you avoid using `window.top`, this script is included for those edge cases where it might be the only option available.

    ```javascript
    function isTopAccessible() {
        try {
                window.top.location;
                return true;
            }
            catch (err) {
                return false;
            }
        }
    }

    var canAccess = isTopAccessible();
    alert(canAccess);
    ```

<a name='problem'></a>

## Problematic patterns

Any usage of `window.top` should be avoided, if possible. The following are examples of commonly seen patterns.

```javascript
// Getting or setting variables at the top level
var myValue = window.top.myGlobalVariable;

// Attempting to access the Xrm namespace at the top level
myValue = window.top.Xrm.Page.getAttribute("field1");
```

<a name='additional'></a>

## Additional information

In the scenarios mentioned, `window.top` refers to the window owned by an application context external to [!include[](../../includes/pn-dynamics-crm.md)]. Due to the differing origins, the browser presents the user with a cross-origin security error.
