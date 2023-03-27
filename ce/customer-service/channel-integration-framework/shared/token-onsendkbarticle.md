The `onsendkbarticle` event is invoked when the user selects the **Send** button in the Knowledge Base control. The eventData are the URL and the title of KB article that you need to pass.

## eventData

The `onsendkbarticle` event takes the following eventData:

| eventData | Example |
|-----------|---------|
| ```{'title": <KB article title>, "link": <url>} ``` | ```{"title": "KB Article about Microsoft Developer Guide", "link": "https://learn.microsoft.com/dynamics365/customer-engagement/developer/developer-guide"}``` |
