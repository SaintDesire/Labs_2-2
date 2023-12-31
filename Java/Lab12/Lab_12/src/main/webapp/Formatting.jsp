<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt" %>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<html>
<head>
    <title>Formatting</title>
</head>
<body>
  <jsp:useBean id="now" class="java.util.Date"/>
  <fmt:setLocale value="en-EN"/>
  Date now: <fmt:formatDate value="${now}" /><br/>
  <fmt:setLocale value="ru-RU"/>
  Date now: <fmt:formatDate value="${now}" /><br/>

  <fmt:formatDate value="${now}" type="time" timeStyle="short"/><br/>
  <fmt:formatDate value="${now}" type="time" timeStyle="medium"/><br/>
  <fmt:formatDate value="${now}" type="time" timeStyle="long"/><br/>

  <c:set var="num" value="161610" scope="page"/>
  Вывод числа <c:out value=" ${num}"/>  в разных форматах<br>
  Процентны:
  <fmt:formatNumber value="${num}" type="percent"/><br/>
  <fmt:setLocale value="be-BY"/>
  Бел рубль:
  <fmt:formatNumber value="${num}" type="currency"/><br/>
  <fmt:setLocale value="fr-FR"/>
  Евро:
  <fmt:formatNumber value="${num}" type="currency"/><br/>


</body>
</html>
