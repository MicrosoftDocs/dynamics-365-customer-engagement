
# Improve Field Service (Dynamics 365) mobile app performance

**PUT IN BETWEEN FAQs AND USE MICROSOFT PLATFORM**

## Remove Console.log from production code 

Logging data to the console can increase memory pressure, as the console prevents items from being cleaned up. It's also best not to log data to the console during production, as this can unintentionally print sensitive data that is observable by the end user. This includes `console.log`, `console.warn`, and `console.error` as well.

## If not using QuickNotes, remove QuickNotes WebResource

The QuickNotes control bundle exists twice within Field Service: once as a PCF control and once as a web resource. If QuickNotes control (or any other control) won't be used, remove the control's `bundle.js` (if present) from the web resources in the form properties. This will prevent downloading the control code when not necessary.

The bundle can be removed by going to the booking and work order form for the bookable resource booking entity, opening **Form Properties**, and removing the `cc_MscrmControls.FieldControls.QuickNotesControl/bundle.js` item from the **Events** tab.

## Minifying Office UI imports in PCF controls

If using the `@fluentui/react` library for interactive UI components, it's possible to import more modules than intended based on how the import is defined. By being specific about the path that you are importing components from, you can dramatically reduce the size of your components (resulting in less data needing to be downloaded).

For example:

```
import { Button } from '@fluentui/react'
should be written as: 
import { Button } from '@fluentui/react/lib/Button';
```

## Utilize connected forms to minimize navigation across different entities

Field Service supports the ability to display fields from different entities within the same form, which can prevent having to jump between different forms. Minimizing navigation means avoiding load times when transitioning from one entity to another and can avoid any possible memory leaks and issues found when jumping between entities. Our memory tests have indicated that form components have a lower peak memory value when navigated to compared to scenarios that use quick-find navigation instead.

For more information, see documentation on how to implement this customization: [Customize Field Service solution](/dynamics365/field-service/mobile-power-app-configure#edit-the-booking-and-work-order-form)

## Remove timeline from entities where it's not used

If the timeline control is not being utilized by the customer, it can be removed to reduce memory usage. This control has been identified as a contributor to memory pressure in customer scenarios, and removing the control has shown to improve memory performance. The root cause of the memory leaks are being investigated.
