const express = require("express");
const app = express();

app.use(express.static("."));
app.use(express.static("../"));
app.use(express.static("File"));

app.listen(3000, () => {
  console.log("Server is running on port 3000");
});
