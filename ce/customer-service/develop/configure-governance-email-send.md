---
title: Add governance validation to a custom email Send command
description: Learn how to add the governance library to an email form, configure a custom Send command, and call governance validation before sending an email.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: how-to
ms.date: 09/18/2026
ms.custom: bap-template
---

# Add governance validation to a custom email Send command

If you replace the default **Send** button with a custom command, the built-in governance validation doesn't run automatically before an email is sent. Call governance validation from your custom code to ensure that governance policies are still enforced.

Use the returned `validationResult` to determine whether to send the email or display a policy violation dialog. If you display the dialog, your command handles the user's response before proceeding.

## Prerequisites

- Your administrator enabled guardrail validation. Learn more in [Configure governance policies](../administer/configure-governance-policies.md). Always invoke `validateForSend` to avoid permitting the email to be sent without additional validation checks.
- The `Governance_main_system_library.js` web resource is deployed in your environment as part of the existing Activities Patch solution.

## Understand how the validation works

Governance guardrails inspect an email before it's sent. Depending on how your administrator configured the guardrails, they can do the following:

- Allow the email to be sent.
- Block the email and display a dialog that explains which policies are violated. The user can override the restriction and send the email, or cancel. The override is recorded.
- Run in shadow mode, which logs violations for reporting without blocking emails.

The module runs validation and, when requested by your code, displays the policy violation dialog. Your command uses the returned `validationResult` to determine whether to send the email or display the dialog and handle the user's response.

## Add the governance library to the email form

The library must be available when the email form loads.

1. Go to [Power Apps](https://make.powerapps.com/).
1. Include the governance library in the email form XML, or add it through the form designer:
   1. Go to **Tables** > **Email** > **Forms**.
   1. Select the email form that uses your custom **Send** command.
   1. Select **Form libraries** > **Add library**.
   1. Add `Governance_main_system_library`.

   :::image type="content" source="../media/governance-custom-send-command.png" alt-text="Screenshot of Send Email within commands.":::
1. Save and publish the form.

## Configure the custom Send command

1. Go to **Tables** > **Email** > **Commands**.
1. Select the **Custom Send** command. The command name might differ in your environment.
1. Select the **Custom Send** button on the designer tab.
1. In the right pane, make sure that `PrimaryControl` is included as a parameter.
1. Save and publish.

## Call the guardrail validation from your custom code

Always call `validateForSend` from your custom command before sending the email. Add the following sample code to your custom JavaScript file to integrate governance validation.

```javascript
// Send command on Email send button
CustomEmail.send = function (primaryControl) {
    // Existing custom code for Email send functionality
    var form = primaryControl;
    var gr = Activities && Activities.GovernanceGuardrail;
    if (!gr || typeof gr.validateForSend !== "function") {
        // Library not loaded - decide your own policy.
        // Here we block to be safe.
        return;
    }
    gr.validateForSend(form).then(function (validationResult) {
        if (validationResult.allowed) {
            <doSend(form)>; // Placeholder for method to send email
            return;
        }
        // Blocked: present the dialog, send only if the user overrides.
        gr.showViolationDialog(form, validationResult).then(function (sendAnyway) {
            if (sendAnyway) {
                <doSend(form)>; // Placeholder for method to send email
            }
            // Otherwise the user cancelled — do nothing.
        });
    });
};

function doSend(primaryControl) {
    // ---- Your existing custom send logic, unchanged ----
    var entityId = primaryControl.data.entity.getId();
    // ... save, call your action / SendEmailRequest, navigate.
}
```

## Verify the integration

1. Import the latest solution into your environment.
1. Open the email form where governance is configured on email send.
1. Select **Send**. Governance validation is triggered.

## Related information

[Configure governance policies](../administer/configure-governance-policies.md)  
[Use governance policies](../use/use-governance-policies.md)
