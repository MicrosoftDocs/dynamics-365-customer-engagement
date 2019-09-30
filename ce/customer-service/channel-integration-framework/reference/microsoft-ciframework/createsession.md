# createSession

Creates a session based on the session template defined as part of the template and returns the unique identifier of the session (Id) that was created.

### Syntax

Microsoft.CIFramework.createSession(input, correlationId).then(successCallback, errorCallback);

**Parameters**

| **Name**                                                                                                                              | **Type** | **Required** | **Description**                                                                                                                      |
|---------------------------------------------------------------------------------------------------------------------------------------|----------|--------------|--------------------------------------------------------------------------------------------------------------------------------------|
| Input: {                                                                                                                              
                                                                                                                                        
 "templateName":"&lt;name\_of\_session\_template&gt;",                                                                                  
                                                                                                                                        
 "templateTag":"&lt;template\_tag&gt;",                                                                                                 
                                                                                                                                        
 "templateParameters": { "global\_param\_1": "number\_value OR boolean\_value OR json\_string\_value OR parameterized\_string\_value",  
                                                                                                                                        
 "global\_param\_2": "….",                                                                                                              
                                                                                                                                        
 "app\_template\_1": {                                                                                                                  
                                                                                                                                        
 "param\_1": "number\_value OR boolean\_value OR json\_string\_value OR parameterized\_string\_value",                                  
                                                                                                                                        
 "param\_2": "..."                                                                                                                      
                                                                                                                                        
 },                                                                                                                                     
                                                                                                                                        
 "app\_template\_2": { ….},                                                                                                             
                                                                                                                                        
 },                                                                                                                                     
                                                                                                                                        
 }                                                                                                                                      | String   | Yes          | JSON string                                                                                                                          |
| successCallback                                                                                                                       | Function | No           | A function to call when the request is successful. The input to this function is the unique identifier of the newly created session. |
| errorCallback                                                                                                                         | Function | No           | A function to call when the request fails                                                                                            |

**Return Value**

## Promise with the value as String

**Example**

var input = {

templateName: "CallSessionTemplate",

// name of the configured template

templateParameters: {

customer: "Contoso",

}

// Global and application tab template parameters, these values will override configured values

};

Microsoft.CIFramework.createSession(input).then(

function success(sessionId) {

console.log(sessionId);

// perform operations on session Id retrieved

},

function (error) {

console.log(error.message);

// handle error conditions

}

);

