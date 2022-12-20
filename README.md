# Human Segmentation과 Depth Map으로 구성된 3D 가상 환경에서의 Selfie-Camera Application 구현
- **Project Name:** Selfie-Camera Application In 3D Virtual Space With Human Segmentation of 360 Image And Depth Map
- **Project Member:** 김현조([@hyunjoebrother](https://github.com/hyunjoebrother/)), 이성인([@adultlee](https://github.com/adultlee/))
- **Project Team:** 인하대학교 정보통신공학과 정보통신종합설계 (지도교수: 이채은 교수님)
- **Project Date:** 2022.06.21 ~ 2022.12.14

<br/><br/>

## ✔요약
본 논문은 Selfie-Camera 어플리케이션을 통해 실내 공간의 360 이미지 배경을 바탕으로 구성된 3D 가상환경에서 사용자는 입체적인 공간과 Object와 상호작용을 경험할 수 있는 서비스를 제안한다. Unity를 통해 이미지 배경으로 3D 가상환경을 구현하고, 해당 환경에서 Human Segmentation으로 real-time하게 사용자와 배경을 자연스럽게 분리하는 동시에 자이로센서를 이용한 Background Control을 한다. 360 이미지로부터 도출한 Depth Map으로 공간 정보를 담고 있는 Point Cloud를 생성하여 Mesh를 구성해 3D 공간 내 Object와 상호작용을 하여 사용자에게 다양한 경험을 제공하도록 한다.


## ✔Abstract
In this paper, we propose a service that user can experience the three-dimensional space which is 3D virtual environment that composed by 360 background indoor-aspect image and can interaction with the object by this Selfie-Camera Application. Using by Unity to develop 3D virtual environment with background image, need to naturally separate user and background on real-time using by Human Segmentation at the same time progress with Background Control by Gyro sensor at same environment. Using Depth Map which derived from the 360 image can generate Point Cloud that contain spatial information and construct the mesh to interaction with object which placed inside of 3D space and finally makes to offer various experience for user. 

<br/><br/>

## ⚙개발환경
- Unity Editor 2020.3.37f1
- Barracuda 1.3.2-preview
- Graphic API - OpenGLES3, minimum API level 24 (Android 7.0 'Nougat')
- `Python 3.9.12` `Open3d 0.15.1` `Conda 4.12.0`
- SW CloudCompare, MeshLAB

<br/><br/>

## ✨설계블록도 flowchart
<img src="https://user-images.githubusercontent.com/66728383/208363628-835830c9-4112-4ca2-bc72-700276e05d24.PNG" width="80%" height="80%">

<br/><br/><br/>

## 📌주요 기능1️⃣ - Human Segmentation
### ✔BodyPix
- ML 라이브러리인 tensorflow를 이용하여 브라우저에서 사람과 신체의 각 부분을 분할
- 딥러닝에 기반한 이미지 분할 분석 모델은 CNN 네트워크를 기반으로 만들어짐 
- [Tensorflow Blog 공식 문서](https://blog.tensorflow.org/2019/11/updated-bodypix-2.html)

### ✔Barracuda
- Unity를 위한 경량으로 크로스 플랫폼의 뉴럴 네트워크 추론 라이브러리
- AI모델의 형태와 무관하게 내장 가능
- [Unity-Technologies 깃허브](https://github.com/Unity-Technologies/barracuda-release)

<img src="https://user-images.githubusercontent.com/66728383/208364043-d57d606c-985c-4a8d-b170-8408ba2bdc3b.png" width="80%" height="80%">

<br/>

## 📌주요 기능2️⃣ - Virtual Space Background
### ✔360 Background Space 생성
- 360 Background Image를 가상 공간 Sphere의 Texture로 입혀서 3D 오브젝트 겉표면에 mapping
### ✔자이로센서 Background Control
- 자이로센서 (Gyro Sensor), 스마트폰의 미세한 회전방향과 기울기를 감지
- 이동하는 각도와 방향에 따라서 Background Control하여 사용자에게 자연스러운 3D 내부 환경을 인식
### ✔Pre-trained Model로 Depth Map 도출
- [Pre-trained Model "Joint_360depth" 깃허브](https://github.com/yuniw18/Joint_360depth)
### ✔Open3d를 통한 Point Cloud 및 Mesh 생성

<img src="https://user-images.githubusercontent.com/66728383/208364331-fe48ec04-8d41-43cf-ad52-568dfe80655e.png" width="40%" height="40%">


<br/><br/>


## 💥Project Result
### ✔Human Segmentation & Android Build
<img src="https://user-images.githubusercontent.com/66728383/208364444-c97cfe94-42c6-49ff-8e6e-45d619760e00.png" width="60%" height="60%">

### ✔Pre-trained Model로 Depth Map 도출 결과
<img src="https://user-images.githubusercontent.com/66728383/208364500-924bcb30-e90b-455c-bef2-e1861f4285c3.png" width="60%" height="60%">

### ✔Point Cloud 및 Mesh 생성 결과
<img src="https://user-images.githubusercontent.com/66728383/208364542-fbf2270a-d7c9-4c6e-adbc-0977114b1f50.png" width="60%" height="60%">

<br/><br/>


## 📊Experimental Analysis
### ✔Pre-trained Model Compare
<img src="https://user-images.githubusercontent.com/66728383/208364632-db654d98-b7ce-4eed-8a96-6d7dab5c4c85.png" width="60%" height="60%">

### ✔FPS Compare by Optimization
<img src="https://user-images.githubusercontent.com/66728383/208364701-a5b8afc6-9522-4a67-88ac-e8b0d73bd148.png" width="60%" height="60%">

|
✒ Optimization
- Resize Background Image Resolution (10000x5000, 29.1MB > 1024x512, 133KB)
- Segmentation useless Mesh (23.5MB > 18.6MB)

<br/>


<img src="https://user-images.githubusercontent.com/66728383/208608074-74890e7c-739b-4b30-b1e6-a05cf95aa661.gif" width="48%" height="48%">
<br>
<img src="https://user-images.githubusercontent.com/66728383/208605295-7f095495-df4f-43bd-b8a9-96defd01bb2f.gif" width="48%" height="48%">





