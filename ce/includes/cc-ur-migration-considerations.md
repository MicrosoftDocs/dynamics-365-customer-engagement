The following considerations are applicable:

- During the import of the data in the target organization, if you see yellow warning symbols, we recommend that you verify the logs in the Configuration Migration Tool for network errors. If the logs contain network errors, redo the import step. You can proceed with the next steps if no network errors are indicated in the logs.

    :::image type="content" source="../customer-service/media/yellow-warnings-in-data-import.png" alt-text="Yellow warnings that indicate errors during data import.":::

    An example of a network error is as follows.
    ```
    Time: 11:46:09 PM
    Error: There was no endpoint listening at `https://www.contoso.com/XRMServices/2011/Organization.svc/web?SDKClientVersion=9.2.46.5279` that could accept the message. This is often caused by an incorrect address or SOAP action. See InnerException, if present, for more details.
    Stack Trace: Service stack trace:
    ```
- After you import the unified routing-related configuration data successfully from the source to target organization, perform the following steps in the target organization:

    1. In the UI, make sure that the unified routing configuration and rulesets are rendered properly and don't display errors.

    1. If skills and rating values are used in unified routing rulesets, then you need to manually link, associate, or create the users, bookable resources, and bookable resources characteristics records.
  
    1. If capacity profiles are used in rulesets and workstreams for unified routing, then you need to manually link, associate, or create the users, bookable resources, and bookable reources capacity profile records.