# ComputerInfo 의존성 가이드 (한국어)

## 개요
이 프로젝트는 두 개의 커스텀 UI 라이브러리가 필요하며, 이들을 수동으로 다운로드하고 설치해야 합니다:
1. **GChartLib** - 모던 차트 시각화 라이브러리
2. **MetroSuite 2.0** - 모던 Windows 8 스타일 컨트롤

## 문제 배경
이 프로젝트는 저장소에 포함되지 않은 로컬 경로의 라이브러리를 참조합니다. 이 가이드는 이러한 의존성을 얻고 설치하는 방법을 안내합니다.

## 필요한 의존성

### 1. GChartLib
**용도**: 시스템 메트릭을 표시하기 위한 모던 차트 및 원형 프로그레스 컨트롤 제공

**원본 소스**: 
- VB Paradise 포럼: http://www.vb-paradise.de/index.php/Thread/118123-GChartLib-Pr%C3%A4sentiert-Daten-auf-eine-neue-moderne-Art/#59da2a65195c6_1

**사용 위치**:
- 스토리지 사용량 원형 프로그레스 표시기 (`GCircularProgress`)
- 메모리 추적 차트 (`GChartLib`)

### 2. MetroSuite 2.0
**용도**: Windows Forms용 Metro/Modern UI 컨트롤 제공

**원본 소스**:
- VB Paradise 포럼: http://www.vb-paradise.de/index.php/Thread/81271-metrocontrols-update-01-11-holt-euch-den-modernen-windows-8-style/

**사용 위치**:
- Metro 스타일 레이블 (`MetroLabel`)
- Metro 스타일 추적 차트 (`MetroTracker`, `MetroTrackerPath`)
- 애플리케이션 전반의 다양한 UI 컴포넌트

## 설치 방법

### 방법 1: 원본 소스에서 다운로드 (접근 가능한 경우 권장)

1. **포럼 접속**:
   - 위의 VB Paradise 포럼 링크를 방문하세요
   - 첨부파일을 다운로드하려면 무료 계정을 만들어야 할 수 있습니다
   - 참고: 독일어 포럼입니다 (구글 번역 사용 권장)

2. **라이브러리 다운로드**:
   - GChartLib 스레드에서 `GChartLib.dll` 다운로드
   - MetroSuite 스레드에서 `MetroSuite 2.0.dll` 다운로드

3. **라이브러리 디렉토리 구조 생성**:
   ```
   프로젝트 루트에 "lib" 폴더 생성:
   ComputerInfo/
   ├── lib/
   │   ├── GChartLib/
   │   │   └── GChartLib.dll
   │   └── MetroSuite/
   │       └── MetroSuite 2.0.dll
   ```

4. **프로젝트 참조 업데이트**:
   - 텍스트 에디터로 `ComputerInfo/ComputerInfo.csproj` 열기
   - 참조 경로 업데이트:
   
   변경 전:
   ```xml
   <Reference Include="GChartLib">
     <HintPath>..\..\..\Form Skins\GChartLib\GChartLib.dll</HintPath>
   </Reference>
   ```
   변경 후:
   ```xml
   <Reference Include="GChartLib">
     <HintPath>..\lib\GChartLib\GChartLib.dll</HintPath>
   </Reference>
   ```
   
   변경 전:
   ```xml
   <Reference Include="MetroSuite 2.0">
     <HintPath>..\..\..\Form Skins\MetroSuite\MetroSuite 2.0.dll</HintPath>
   </Reference>
   ```
   변경 후:
   ```xml
   <Reference Include="MetroSuite 2.0">
     <HintPath>..\lib\MetroSuite\MetroSuite 2.0.dll</HintPath>
   </Reference>
   ```

### 방법 2: 대안 솔루션

원본 소스에 접근할 수 없는 경우, 다음 대안을 고려하세요:

1. **저장소 소유자에게 문의**:
   - 원 저자가 이러한 라이브러리의 사본을 가지고 있을 수 있습니다
   - GitHub 저장소에 이슈를 생성하여 DLL 파일을 요청하세요

2. **대체 라이브러리 사용** (코드 변경 필요):
   - 차트용: **LiveCharts** 또는 **OxyPlot** 고려
   - Metro UI용: 이미 포함된 **MetroFramework** 사용
   - 참고: 이 방법은 상당한 코드 리팩토링이 필요합니다

## 검증

설치 후 다음과 같이 설정을 확인하세요:

1. Visual Studio에서 솔루션 열기
2. 프로젝트 빌드 (Ctrl+Shift+B)
3. 오류 목록에서 참조 오류 확인
4. 성공 시 "빌드 성공" 메시지가 표시됩니다

## 문제 해결

### "파일 또는 어셈블리 'GChartLib'을(를) 로드할 수 없습니다" 또는 유사한 오류

**해결 방법**: 
- DLL 파일이 올바른 위치에 있는지 확인
- `.csproj` 파일의 HintPath가 올바른지 확인
- 솔루션 정리 후 다시 빌드 (빌드 → 솔루션 정리)

### "'GChartLib' 형식 또는 네임스페이스 이름을 찾을 수 없습니다"

**해결 방법**:
- DLL 파일이 유효한 .NET 어셈블리인지 확인
- 대상 프레임워크 버전이 호환되는지 확인 (.NET Framework 4.8)
- DLL 파일이 차단되지 않았는지 확인 (우클릭 → 속성 → 차단 해제)

### 포럼 접근 문제

**해결 방법**:
- 독일어 콘텐츠를 위해 번역 도구 사용 (예: Google 번역)
- VB Paradise 포럼에 무료 계정 생성
- 이러한 라이브러리의 대체 호스팅/미러 검색

## 추가 리소스

- **MetroFramework**: 이미 NuGet 패키지로 포함됨 (조치 불필요)
- **MaterialSkin**: 이미 NuGet 패키지로 포함됨 (조치 불필요)
- **프로젝트 문서**: 일반 프로젝트 정보는 README.md 참조

## 기여

이러한 라이브러리를 성공적으로 얻었다면 다음을 고려해주세요:
1. 과정 문서화
2. 대체 소스 공유 (적절한 라이선스와 함께)
3. 향후 사용자들이 이러한 의존성을 더 쉽게 얻을 수 있도록 기여

## 라이선스 고려사항

두 라이브러리 모두 포럼에서 자유롭게 배포되는 것으로 보이지만, 다음 사항을 준수하세요:
- 원 저자의 라이선스를 존중하세요
- 허가 없이 재배포하지 마세요
- 프로젝트에서 원 저자를 명시하세요
