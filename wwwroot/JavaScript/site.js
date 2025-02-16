$(document).ready(function () {
  $("#pot").click(function () {
    $(".p").show(1000);
    $(".s").hide(1000);
  });

  $("#seed").click(function () {
    $(".p").hide(1000);
    $(".s").show(1000);
  });
});
