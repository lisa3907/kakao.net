window.kakaoMapInterop =
    {
        drawMap: function (latitude, longitude) {
            var container = document.getElementById('map'); //지도를 담을 영역의 DOM 레퍼런스
            var options =
            {
                //지도를 생성할 때 필요한 기본 옵션
                center: new daum.maps.LatLng(latitude, longitude), //지도의 중심좌표.
                level: 3 //지도의 레벨(확대, 축소 정도)
            };

            var map = new daum.maps.Map(container, options); //지도 생성 및 객체 리턴
            return true;
        },
        drawTraffic: function (latitude, longitude) {
            var container = document.getElementById('map'); //지도를 담을 영역의 DOM 레퍼런스
            var options =
            {
                //지도를 생성할 때 필요한 기본 옵션
                center: new daum.maps.LatLng(latitude, longitude), //지도의 중심좌표.
                level: 3 //지도의 레벨(확대, 축소 정도)
            };

            var map = new daum.maps.Map(container, options); //지도 생성 및 객체 리턴
            // 지도에 교통정보를 표시하도록 지도타입을 추가합니다
            map.addOverlayMapTypeId(daum.maps.MapTypeId.TRAFFIC);

            return true;
        }
    };