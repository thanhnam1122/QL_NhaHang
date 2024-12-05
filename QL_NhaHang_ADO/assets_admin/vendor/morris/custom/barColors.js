// Morris Bar Colors
Morris.Bar({
	element: "barColors",
	data: [
		{ x: "January", Sales: 6 },
		{ x: "February", Sales: 1 },
		{ x: "March", Sales: 2 },
		{ x: "April", Sales: 3 },
		{ x: "May", Sales: 2 },
		{ x: "June", Sales: 4 },
		{ x: "July", Sales: 7 },
		{ x: "August", Sales: 2 },
		{ x: "September", Sales: 5 },
		{ x: "October", Sales: 9 },
		{ x: "November", Sales: 3 },
		{ x: "December", Sales: 5 },
	],
	xkey: "x",
	ykeys: ["Sales"],
	labels: ["Sales"],
	resize: true,
	gridLineColor: "#cccccc",
	hideHover: "auto",
	barColors: [
		"#0068ff",
		"#3386ff",
		"#4d95ff",
		"#66a4ff",
		"#80b4ff",
		"#99c3ff",
		"#b3d2ff",
		"#cce1ff",
	],
});