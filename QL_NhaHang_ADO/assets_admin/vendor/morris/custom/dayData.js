// Morris Days
var day_data = [
	{ period: "2023-10-01", licensed: 3213, "Bootstrap Gallery": 887 },
	{ period: "2023-09-30", licensed: 3321, "Bootstrap Gallery": 776 },
	{ period: "2023-09-29", licensed: 3671, "Bootstrap Gallery": 884 },
	{ period: "2023-09-20", licensed: 3176, "Bootstrap Gallery": 448 },
	{ period: "2023-09-19", licensed: 3376, "Bootstrap Gallery": 565 },
	{ period: "2023-09-18", licensed: 3976, "Bootstrap Gallery": 627 },
	{ period: "2023-09-17", licensed: 2239, "Bootstrap Gallery": 660 },
	{ period: "2023-09-16", licensed: 3871, "Bootstrap Gallery": 676 },
	{ period: "2023-09-15", licensed: 3659, "Bootstrap Gallery": 656 },
	{ period: "2023-09-10", licensed: 3380, "Bootstrap Gallery": 663 },
];
Morris.Line({
	element: "dayData",
	data: day_data,
	xkey: "period",
	ykeys: ["licensed", "Bootstrap Gallery"],
	labels: ["Licensed", "Bootstrap Gallery"],
	resize: true,
	hideHover: "auto",
	gridLineColor: "#cccccc",
	pointFillColors: [
		"#0068ff",
		"#3386ff",
		"#4d95ff",
		"#66a4ff",
		"#80b4ff",
		"#99c3ff",
		"#b3d2ff",
		"#cce1ff",
	],
	pointStrokeColors: ["#ffffff"],
	lineColors: [
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