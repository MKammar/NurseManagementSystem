// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(function ($) {

	"use strict";



	$('#sidebarCollapse').on('click', function () {
		$('#sidebar').toggleClass('active');
	});

})(jQuery);

$(function () {
	$('[data-toggle="tooltip"]').tooltip();
	$('[data-toggle="popover"]').popover({
		placement: 'bottom',
		content: function () {
			return $("#notification-content").html();
		},
		html: true
	});

	$('body').append(`<div id="notification-content" class="hide"></div>`)

	function getNotification() {
		var res = "<ul class='list-group'>";
		console.log("hello");
		$.ajax({
			url: "/Notification/getNotification",
			method: "GET",
			success: function (result) {

				if (result.count != 0) {
					$("#notificationCount").html(result.count);
					$("#notificationCount").show('slow');
				} else {
					$("#notificationCount").html();
					$("#notificationCount").hide('slow');
					$("#notificationCount").popover('hide');
				}

				var notifications = result.userNotification;
				notifications.forEach(element => {

					res = res + "<li class='list-group-item notification-text' data-id='" + element.notification.id + "'>" + element.notification.message + "</li>";
				});

				res = res + "</ul>";

				$("#notification-content").html(res);

				console.log(result);
			},
			error: function (error) {
				console.log(error);
			}
		});
	} 

	$(document).on('click', '.notification-text', function (e) {
		var target = e.target;
		var id = $(".notification-text").data('id');
		
		readNotification(id, target);
		
	});

	function readNotification(id, target) {
		$.ajax({
			url: "/Notification/ReadNotification",
			method: "GET",
			data: { notificationId: id },
			success: function (result) {
				getNotification();
				$(target).fadeOut('slow');
			},
			error: function (error) {
				console.log(error);
			}
		})
	}

	getNotification();

	let connection = new  signalR.HubConnectionBuilder()
		.withUrl("/signalServer")
		.configureLogging(signalR.LogLevel.Information)
		.build();
	
	connection.on('displayNotification', () => {
		getNotification();
		
	});

	connection.start();

   
});