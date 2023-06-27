<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix = "ex" uri = "userTags" %>
<html>
<head>
    <title>UserTags</title>
    <link rel="stylesheet" href="Core.css">
</head>
<body>
    <ex:KniSubmit/>
    <br/>
    <div style="margin-top: 20px">
        <ex:KniPrintTable nameTable="users" nameDB="java"/>
    </div>
</body>
</html>
